using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace VxDataSourceViewer
{
    public partial class frmMain : Form
    {
        public static VXSystem testSystem { get; set; } //  VideoXpert 시스템 (서버) 오브젝트       
        public static string wk_LicenseString = "DCovPywTKiY5LgolLiYsKCI/MywlBRUTdxAAD24BHw0YFQ0="; // INT-JENSON 에 매치되는 SDK 라이센스 키

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtVxCoreIP.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            // 서버 오브젝트를 생성하고 연결합니다

            testSystem = new VXSystem(txtVxCoreIP.Text, Convert.ToInt32("443"), true, wk_LicenseString);
            try
            {

                var result = testSystem.Login(txtUsername.Text, txtPassword.Text);

                // SDK 라이센스 적용 확인 및 트라이얼 기간인경우 경고 처리

                if (result == Results.Value.SdkLicenseGracePeriodActive)
                {
                    DateTime expirationTime = testSystem.GraceLicenseExpirationTime;

                    string _expDate = expirationTime.ToLocalTime().ToShortDateString();
                    string _expTime = expirationTime.ToLocalTime().ToShortTimeString();


                    MessageBox.Show("SDK 트라이얼 라이센스를 사용중이며" + _expDate + " " + _expTime + "에 만료됩니다.", "SDK 라이센스 필요", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (result != Results.Value.OK)
                {
                    testSystem.Dispose();
                    if (result == Results.Value.SdkLicenseGracePeriodExpired)
                        MessageBox.Show("SDK 트라이얼 라이센스가 만료되었습니다. 올바른 라이센스를 적용해주세요", "SDK 라이센스 경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("로그인 오류 발생: " + result, "시스템 로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("예외 발생: " + ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 접속이 완료되면 필요한 오브젝트 생성

            User user = testSystem.Currentuser;
            Device sysDevice = testSystem.HostDevice;

            List<DataSource> testDataSources = testSystem.DataSources;

            foreach (DataSource ds in testDataSources)
            {
                lstDataSources.Items.Add(ds.Name);
            }

            lblConnectionResult.Text = "Vx 시스템 [" + sysDevice.Name + "] 에 [" + user.Name + "] 으로 접속 성공";
        }
    }
}
