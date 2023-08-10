
namespace VxDataSourceViewer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVxCoreIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDataSources = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyURL = new System.Windows.Forms.Button();
            this.txtRtspEndpointURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCamIP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstDataInterfaces = new System.Windows.Forms.ListBox();
            this.lblCamUUID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCamName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCamNumber = new System.Windows.Forms.Label();
            this.lblConnectionResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVxCoreIP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1233, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VxPro / VxCore Login Information";
            // 
            // txtVxCoreIP
            // 
            this.txtVxCoreIP.Location = new System.Drawing.Point(100, 32);
            this.txtVxCoreIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVxCoreIP.Name = "txtVxCoreIP";
            this.txtVxCoreIP.Size = new System.Drawing.Size(167, 29);
            this.txtVxCoreIP.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Server IP:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(944, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(167, 31);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(643, 32);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 29);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(401, 32);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 29);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // lstDataSources
            // 
            this.lstDataSources.FormattingEnabled = true;
            this.lstDataSources.ItemHeight = 21;
            this.lstDataSources.Location = new System.Drawing.Point(25, 163);
            this.lstDataSources.Name = "lstDataSources";
            this.lstDataSources.Size = new System.Drawing.Size(333, 466);
            this.lstDataSources.TabIndex = 1;
            this.lstDataSources.SelectedIndexChanged += new System.EventHandler(this.lstDataSources_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopyURL);
            this.groupBox2.Controls.Add(this.txtRtspEndpointURL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCamIP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lstDataInterfaces);
            this.groupBox2.Controls.Add(this.lblCamUUID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblCamName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCamNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(364, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 469);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information on the selected camera (DataSource)";
            // 
            // btnCopyURL
            // 
            this.btnCopyURL.Location = new System.Drawing.Point(763, 358);
            this.btnCopyURL.Name = "btnCopyURL";
            this.btnCopyURL.Size = new System.Drawing.Size(112, 30);
            this.btnCopyURL.TabIndex = 14;
            this.btnCopyURL.Text = "Copy Address";
            this.btnCopyURL.UseVisualStyleBackColor = true;
            this.btnCopyURL.Click += new System.EventHandler(this.btnCopyURL_Click);
            // 
            // txtRtspEndpointURL
            // 
            this.txtRtspEndpointURL.Location = new System.Drawing.Point(25, 393);
            this.txtRtspEndpointURL.Name = "txtRtspEndpointURL";
            this.txtRtspEndpointURL.ReadOnly = true;
            this.txtRtspEndpointURL.Size = new System.Drawing.Size(850, 29);
            this.txtRtspEndpointURL.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "RTSP Endpoint Address for Primary Unicast Stream";
            // 
            // lblCamIP
            // 
            this.lblCamIP.AutoSize = true;
            this.lblCamIP.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCamIP.Location = new System.Drawing.Point(101, 46);
            this.lblCamIP.Name = "lblCamIP";
            this.lblCamIP.Size = new System.Drawing.Size(118, 25);
            this.lblCamIP.TabIndex = 11;
            this.lblCamIP.Text = "(Camera IP)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "DataInterfaces";
            // 
            // lstDataInterfaces
            // 
            this.lstDataInterfaces.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstDataInterfaces.FormattingEnabled = true;
            this.lstDataInterfaces.HorizontalScrollbar = true;
            this.lstDataInterfaces.ItemHeight = 15;
            this.lstDataInterfaces.Location = new System.Drawing.Point(25, 252);
            this.lstDataInterfaces.Name = "lstDataInterfaces";
            this.lstDataInterfaces.Size = new System.Drawing.Size(850, 94);
            this.lstDataInterfaces.TabIndex = 8;
            // 
            // lblCamUUID
            // 
            this.lblCamUUID.AutoSize = true;
            this.lblCamUUID.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCamUUID.Location = new System.Drawing.Point(101, 175);
            this.lblCamUUID.Name = "lblCamUUID";
            this.lblCamUUID.Size = new System.Drawing.Size(74, 25);
            this.lblCamUUID.TabIndex = 7;
            this.lblCamUUID.Text = "(UUID)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "UUID";
            // 
            // lblCamName
            // 
            this.lblCamName.AutoSize = true;
            this.lblCamName.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCamName.Location = new System.Drawing.Point(101, 132);
            this.lblCamName.Name = "lblCamName";
            this.lblCamName.Size = new System.Drawing.Size(153, 25);
            this.lblCamName.TabIndex = 5;
            this.lblCamName.Text = "(Camera Name)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // lblCamNumber
            // 
            this.lblCamNumber.AutoSize = true;
            this.lblCamNumber.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCamNumber.Location = new System.Drawing.Point(101, 89);
            this.lblCamNumber.Name = "lblCamNumber";
            this.lblCamNumber.Size = new System.Drawing.Size(127, 25);
            this.lblCamNumber.TabIndex = 3;
            this.lblCamNumber.Text = "(Camera No)";
            // 
            // lblConnectionResult
            // 
            this.lblConnectionResult.AutoSize = true;
            this.lblConnectionResult.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConnectionResult.Location = new System.Drawing.Point(12, 93);
            this.lblConnectionResult.Name = "lblConnectionResult";
            this.lblConnectionResult.Size = new System.Drawing.Size(228, 25);
            this.lblConnectionResult.TabIndex = 4;
            this.lblConnectionResult.Text = "(Connected Server Info)";
            this.lblConnectionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "List of Cameras";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1079, 638);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "QUIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 683);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConnectionResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstDataSources);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VxSDK DataSource Explorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDataSources;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCamUUID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCamName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCamNumber;
        private System.Windows.Forms.TextBox txtVxCoreIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstDataInterfaces;
        private System.Windows.Forms.Label lblConnectionResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCamIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRtspEndpointURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopyURL;
        private System.Windows.Forms.Button btnExit;
    }
}

