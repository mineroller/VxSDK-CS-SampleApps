using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace VxDataSourceViewer
{
    public partial class frmMain : Form
    {
        // Pelco VideoXpert SDK 데모용 DataSource 탐색기 예제프로그램 (한글판)
        // Copyright 2021 Jonathan Lee | jonathan.lee1@pelco.com
        //
        //
        // [간단한 VideoXpert 데이터 구조 설명]:
        // System:          VideoXpert 서버
        // -Device:          하드웨어 장치 (카메라, 인코더, 녹화장비 등)
        // ---DataSource:      각 Device 에서 생성해줄수 있는 데이터 (비디오, 오디오, 메타데이터, 이미지 등)
        // -----DataInterface:   특정한 DataSource를 실제로 가져갈 수 있는 프로토콜의 주소 또는 위치 (RTSP, JPEG, G.711 등)
        //
        //
        // 하나의 System 안에는 한 개 이상의 Device 가 있습니다
        // 하나의 Device 안에는 한 개 이상의 DataSource 가 있습니다
        // 하나의 DataSource 안에는 한 개 이상의 DataInterface 가 있습니다
        //
        //
        // 따라서 특정 카메라의 영상을 받기 위한 RTSP 스트림 주소 (DataInterface) 를 찾기 위해서는 
        // System - Device - DataSource - DataInterface 의 순서대로 찾아가면 됩니다.


        public static VXSystem vxSystem { get; set; } //  VideoXpert 서버 (System) 오브젝트
                                                        
        public static List<DataSource> vxDataSources { get; set; } // 카메라 (DataSource) 목록 오브젝트. SDK문서 IVxDataSource 내용 참조
               
        public static string jk_LicenseString = "DCovPywTKiY5LgolLiYsKCI/MywlBRUTdxAAD24BHw0YFQ0="; // 젠슨코리아 전용 라이센스키. INT-JENSON과 매치됨

        public frmMain()
        {
            InitializeComponent();

            // 접속전까지 UI 비활성화
            lstDataSources.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtVxCoreIP.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            

            // 서버 오브젝트를 생성하고 연결합니다

            vxSystem = new VXSystem(txtVxCoreIP.Text, Convert.ToInt32("443"), true, jk_LicenseString);
            try
            {

                var result = vxSystem.Login(txtUsername.Text, txtPassword.Text);

                // SDK 라이센스 적용 확인 및 트라이얼 기간인경우 경고 처리                

                if (result == Results.Value.SdkLicenseGracePeriodActive)
                {
                    DateTime expirationTime = vxSystem.GraceLicenseExpirationTime;

                    string _expDate = expirationTime.ToLocalTime().ToShortDateString();
                    string _expTime = expirationTime.ToLocalTime().ToShortTimeString();


                    MessageBox.Show("SDK 트라이얼 라이센스를 사용중입니다. 라이센스가 " + _expDate + " " + _expTime + "에 만료됩니다.", "SDK 라이센스 필요", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (result != Results.Value.OK)
                {
                    vxSystem.Dispose();
                    if (result == Results.Value.SdkLicenseGracePeriodExpired)
                        MessageBox.Show("SDK 트라이얼 라이센스가 만료되었습니다. 올바른 라이센스를 적용해주세요", "SDK 라이센스 경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("로그인 오류 발생: " + result, "시스템 로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVxCoreIP.Enabled = true;
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    return;
                }               
            }

            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 접속 완료. 시스템 정보 표시 후 UI 활성화            

            User loginUser = vxSystem.Currentuser;
            Device loginSystem = vxSystem.HostDevice;

            lblConnectionResult.Text = "Vx 시스템 [" + loginSystem.Name + "] 에 [" + loginUser.Name + "] 으로 접속 성공";

            btnConnect.Enabled = false;
            lstDataSources.Enabled = true;
            groupBox2.Enabled = true;


            vxDataSources = vxSystem.DataSources; // 시스템에서 제공한 데이터소스 (카메라) 목록 리스트

            foreach (DataSource ds in vxDataSources)
            {
                if (ds.Type == DataSource.Types.Video) // 영상 데이터소스인 경우에만 리스트에 추가 (오디오 등 불필요한 데이터소스 제외)
                {                    
                    lstDataSources.Items.Add(ds.Name);
                }                
            }
                        
        }

        private void lstDataSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDataInterfaces.Items.Clear();
            
            // 데이터소스 목록을 선택하면 해당 소스의 세부정보를 표시하고, 두번째 Listbox에 DataInterface를 채움
            
            DataSource selectedDS = vxDataSources.FirstOrDefault(d => d.Name == lstDataSources.SelectedItem.ToString());
            lblCamIP.Text = selectedDS.Ip;
            lblCamName.Text = selectedDS.Name;
            lblCamNumber.Text = selectedDS.Number.ToString();
            lblCamUUID.Text = selectedDS.Id;

            List<DataInterface> listDI = selectedDS.DataInterfaces; // 데이터소스 오브젝트에 포함되는 인터페이스 리스트 확보

            foreach (DataInterface di in listDI)
            {
                lstDataInterfaces.Items.Add(di.DataEndpoint);
                if (di.DataEncodingId == "primary" && di.SupportsMulticast == false) // 유니캐스트 고화질 1차스트림 주소 선택
                {
                    txtRtspEndpointURL.Text = di.DataEndpoint; // 최종적으로 사용할 RTSP 주소. 복사해서 VLC로 재생 테스트 가능
                }
            }


        }

        private void btnCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtRtspEndpointURL.Text);

            MessageBox.Show("URL이 클립보드로 복사되었습니다", "Endpoint 주소 복사", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
