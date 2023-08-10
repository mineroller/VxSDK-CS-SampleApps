﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace VxDataSourceViewer
{
    public partial class frmMain : Form
    {
        // Pelco VideoXpert SDK Demo: DataSource Explorer Application (English)
        // Copyright 2021 Jonathan Lee | jonathan.lee1@pelco.com
        //
        //
        // [Basic Structure of VideoXpert Devices]:
        // System:          VideoXpert Server
        // -Device:          Hardware Device Itself (Camera, Encoder, Storage Server, etc)
        // ---DataSource:      Type of data (Video, Audio, Metadata, Image, etc) that can be generated by this particular device
        // -----DataInterface:   Specific address of location of the particular DataSource (such as RTSP, JPEG, G.711 Audio)
        //
        //
        // One [System] contains one or more [Device]s.
        // One [Device] contains one or more [DataSource]s.
        // One [DataSource] contains one or more [DataInterface]s.
        //
        //
        // Getting a streamable address (such as RTSP) goes in step-by-step process of discovery:
        // System -> Device -> DataSource -> DataInterface


        public static VXSystem vxSystem { get; set; } //  VideoXpert Server (System) Object
                                                        
        public static List<DataSource> vxDataSources { get; set; } // Camera (DataSource) Objects, contained in a list. Refer to IVxDataSource in SDK Reference.
               
        public static string jk_LicenseString = "DCovPywTKiY5LgolLiYsKCI/MywlBRUTdxAAD24BHw0YFQ0="; // Sample License key (SKU: INT-JENSON). 

        public frmMain()
        {
            InitializeComponent();

            // Disable UI until "connected"
            lstDataSources.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtVxCoreIP.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            

            // Create a System object and connect to it

            vxSystem = new VXSystem(txtVxCoreIP.Text, Convert.ToInt32("443"), true, jk_LicenseString);
            try
            {

                var result = vxSystem.Login(txtUsername.Text, txtPassword.Text);

                // Generate warning if trial license is being used                

                if (result == Results.Value.SdkLicenseGracePeriodActive)
                {
                    DateTime expirationTime = vxSystem.GraceLicenseExpirationTime;

                    string _expDate = expirationTime.ToLocalTime().ToShortDateString();
                    string _expTime = expirationTime.ToLocalTime().ToShortTimeString();


                    MessageBox.Show("System is using VxSDK Trial License. The License will expire on " + _expDate + " " + _expTime + ".", "SDK License Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (result != Results.Value.OK)
                {
                    vxSystem.Dispose();
                    if (result == Results.Value.SdkLicenseGracePeriodExpired)
                        MessageBox.Show("SDK Trial License expried. Please apply a valid active license.", "SDK License Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Login ERROR: " + result, "Error while logging into Vx", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVxCoreIP.Enabled = true;
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    return;
                }               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect Success. Display quick info and enable UI elements.          

            User loginUser = vxSystem.Currentuser;
            Device loginSystem = vxSystem.HostDevice;

            lblConnectionResult.Text = "Vx system [" + loginSystem.Name + "] connected under user [" + loginUser.Name + "]";

            btnConnect.Enabled = false;
            lstDataSources.Enabled = true;
            groupBox2.Enabled = true;


            vxDataSources = vxSystem.DataSources; // List of Cameras (DataSources) provided by System

            foreach (DataSource ds in vxDataSources)
            {
                if (ds.Type == DataSource.Types.Video) // For this sample, only find Video DataSources (no audio or metadata)
                {                    
                    lstDataSources.Items.Add(ds.Name);
                }                
            }
                        
        }

        private void lstDataSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDataInterfaces.Items.Clear();
            
            // Selecting a DataSource displays its details and populates DataInterface listbox.
            
            DataSource selectedDS = vxDataSources.FirstOrDefault(d => d.Name == lstDataSources.SelectedItem.ToString());
            lblCamIP.Text = selectedDS.Ip;
            lblCamName.Text = selectedDS.Name;
            lblCamNumber.Text = selectedDS.Number.ToString();
            lblCamUUID.Text = selectedDS.Id;

            List<DataInterface> listDI = selectedDS.DataInterfaces;

            foreach (DataInterface di in listDI)
            {
                lstDataInterfaces.Items.Add(di.DataEndpoint);
                if (di.DataEncodingId == "primary" && di.SupportsMulticast == false) // Choose the Primary Unicast stream
                {
                    txtRtspEndpointURL.Text = di.DataEndpoint; // Final RTSP endpoint address, that can be loaded in players such as FFMPEG or VLC.
                }
            }


        }

        private void btnCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtRtspEndpointURL.Text);

            MessageBox.Show("URL Copied to Clipboard", "Copy Endpoint URL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
