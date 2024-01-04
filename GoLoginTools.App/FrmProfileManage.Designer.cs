namespace GoLoginTools.App
{
    partial class FrmProfileManage
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
            groupBox1 = new GroupBox();
            tbStartUrl = new TextBox();
            label15 = new Label();
            tbNotes = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            label1 = new Label();
            tbUserAgent = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            cbbProxyMode = new ComboBox();
            tbProxyPort = new TextBox();
            label6 = new Label();
            tbPassword = new TextBox();
            label8 = new Label();
            tbUserName = new TextBox();
            label7 = new Label();
            tbProxyHost = new TextBox();
            label5 = new Label();
            cbUseAuthenticate = new CheckBox();
            cbProxyEnable = new CheckBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label12 = new Label();
            cbWebRtcEnable = new CheckBox();
            cbbWebRtcMode = new ComboBox();
            tbWebRtcLocalIps = new TextBox();
            label14 = new Label();
            tbWebRtcPublicIp = new TextBox();
            label13 = new Label();
            cbWebRtcFillBaseIp = new CheckBox();
            cbWebRtcIpMasking = new CheckBox();
            cbWebRtcCustomize = new CheckBox();
            tbCanvasNoise = new TextBox();
            cbbCanvasMode = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            tbResolution = new TextBox();
            label9 = new Label();
            cbPasswordSaving = new CheckBox();
            cbSessionSaving = new CheckBox();
            cbExtensionsSaving = new CheckBox();
            cbHistorySaving = new CheckBox();
            cbEnableGServices = new CheckBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbStartUrl);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tbNotes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Basic Information";
            // 
            // tbStartUrl
            // 
            tbStartUrl.Location = new Point(88, 86);
            tbStartUrl.Name = "tbStartUrl";
            tbStartUrl.Size = new Size(193, 27);
            tbStartUrl.TabIndex = 1;
            tbStartUrl.Text = "google.com";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 89);
            label15.Name = "label15";
            label15.Size = new Size(70, 20);
            label15.TabIndex = 0;
            label15.Text = "Start URL";
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(88, 53);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(193, 27);
            tbNotes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "Notes";
            // 
            // tbName
            // 
            tbName.Location = new Point(88, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(193, 27);
            tbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tbUserAgent
            // 
            tbUserAgent.Location = new Point(342, 23);
            tbUserAgent.Name = "tbUserAgent";
            tbUserAgent.Size = new Size(193, 27);
            tbUserAgent.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 26);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "User Agent";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbbProxyMode);
            groupBox2.Controls.Add(tbProxyPort);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbPassword);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbUserName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbProxyHost);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbUseAuthenticate);
            groupBox2.Controls.Add(cbProxyEnable);
            groupBox2.Location = new Point(348, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 178);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proxy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 29);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Mode";
            // 
            // cbbProxyMode
            // 
            cbbProxyMode.FormattingEnabled = true;
            cbbProxyMode.Items.AddRange(new object[] { "None", "HTTP,", "SOCKS" });
            cbbProxyMode.Location = new Point(293, 23);
            cbbProxyMode.Name = "cbbProxyMode";
            cbbProxyMode.Size = new Size(203, 28);
            cbbProxyMode.TabIndex = 1;
            // 
            // tbProxyPort
            // 
            tbProxyPort.Location = new Point(50, 129);
            tbProxyPort.Name = "tbProxyPort";
            tbProxyPort.Size = new Size(154, 27);
            tbProxyPort.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 132);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 0;
            label6.Text = "Port";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(321, 132);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(175, 27);
            tbPassword.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 135);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 0;
            label8.Text = "Password";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(321, 96);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(175, 27);
            tbUserName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 99);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 0;
            label7.Text = "Username";
            // 
            // tbProxyHost
            // 
            tbProxyHost.Location = new Point(50, 96);
            tbProxyHost.Name = "tbProxyHost";
            tbProxyHost.Size = new Size(154, 27);
            tbProxyHost.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 99);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 0;
            label5.Text = "Host";
            // 
            // cbUseAuthenticate
            // 
            cbUseAuthenticate.AutoSize = true;
            cbUseAuthenticate.Location = new Point(239, 66);
            cbUseAuthenticate.Name = "cbUseAuthenticate";
            cbUseAuthenticate.Size = new Size(143, 24);
            cbUseAuthenticate.TabIndex = 0;
            cbUseAuthenticate.Text = "Use Authenticate";
            cbUseAuthenticate.UseVisualStyleBackColor = true;
            // 
            // cbProxyEnable
            // 
            cbProxyEnable.AutoSize = true;
            cbProxyEnable.Location = new Point(6, 26);
            cbProxyEnable.Name = "cbProxyEnable";
            cbProxyEnable.Size = new Size(76, 24);
            cbProxyEnable.TabIndex = 0;
            cbProxyEnable.Text = "Enable";
            cbProxyEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(tbCanvasNoise);
            groupBox3.Controls.Add(cbbCanvasMode);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(tbResolution);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbUserAgent);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbPasswordSaving);
            groupBox3.Controls.Add(cbSessionSaving);
            groupBox3.Controls.Add(cbExtensionsSaving);
            groupBox3.Controls.Add(cbHistorySaving);
            groupBox3.Controls.Add(cbEnableGServices);
            groupBox3.Location = new Point(12, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(848, 261);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Other";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cbWebRtcEnable);
            groupBox4.Controls.Add(cbbWebRtcMode);
            groupBox4.Controls.Add(tbWebRtcLocalIps);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(tbWebRtcPublicIp);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(cbWebRtcFillBaseIp);
            groupBox4.Controls.Add(cbWebRtcIpMasking);
            groupBox4.Controls.Add(cbWebRtcCustomize);
            groupBox4.Location = new Point(557, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(285, 227);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "WebRTC";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 58);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 2;
            label12.Text = "Mode";
            // 
            // cbWebRtcEnable
            // 
            cbWebRtcEnable.AutoSize = true;
            cbWebRtcEnable.Checked = true;
            cbWebRtcEnable.CheckState = CheckState.Checked;
            cbWebRtcEnable.Location = new Point(6, 26);
            cbWebRtcEnable.Name = "cbWebRtcEnable";
            cbWebRtcEnable.Size = new Size(76, 24);
            cbWebRtcEnable.TabIndex = 0;
            cbWebRtcEnable.Text = "Enable";
            cbWebRtcEnable.UseVisualStyleBackColor = true;
            // 
            // cbbWebRtcMode
            // 
            cbbWebRtcMode.FormattingEnabled = true;
            cbbWebRtcMode.Items.AddRange(new object[] { "Alerted", "Disabled", "Real,", "Public" });
            cbbWebRtcMode.Location = new Point(60, 52);
            cbbWebRtcMode.Name = "cbbWebRtcMode";
            cbbWebRtcMode.Size = new Size(219, 28);
            cbbWebRtcMode.TabIndex = 1;
            // 
            // tbWebRtcLocalIps
            // 
            tbWebRtcLocalIps.Location = new Point(84, 183);
            tbWebRtcLocalIps.Name = "tbWebRtcLocalIps";
            tbWebRtcLocalIps.Size = new Size(193, 27);
            tbWebRtcLocalIps.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 186);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 0;
            label14.Text = "Local IPs";
            // 
            // tbWebRtcPublicIp
            // 
            tbWebRtcPublicIp.Location = new Point(84, 150);
            tbWebRtcPublicIp.Name = "tbWebRtcPublicIp";
            tbWebRtcPublicIp.Size = new Size(193, 27);
            tbWebRtcPublicIp.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 153);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 0;
            label13.Text = "Public IP";
            // 
            // cbWebRtcFillBaseIp
            // 
            cbWebRtcFillBaseIp.AutoSize = true;
            cbWebRtcFillBaseIp.Checked = true;
            cbWebRtcFillBaseIp.CheckState = CheckState.Checked;
            cbWebRtcFillBaseIp.Location = new Point(6, 120);
            cbWebRtcFillBaseIp.Name = "cbWebRtcFillBaseIp";
            cbWebRtcFillBaseIp.Size = new Size(131, 24);
            cbWebRtcFillBaseIp.TabIndex = 0;
            cbWebRtcFillBaseIp.Text = "Fill based on IP";
            cbWebRtcFillBaseIp.UseVisualStyleBackColor = true;
            // 
            // cbWebRtcIpMasking
            // 
            cbWebRtcIpMasking.AutoSize = true;
            cbWebRtcIpMasking.Location = new Point(112, 90);
            cbWebRtcIpMasking.Name = "cbWebRtcIpMasking";
            cbWebRtcIpMasking.Size = new Size(141, 24);
            cbWebRtcIpMasking.TabIndex = 0;
            cbWebRtcIpMasking.Text = "Local IP Masking";
            cbWebRtcIpMasking.UseVisualStyleBackColor = true;
            // 
            // cbWebRtcCustomize
            // 
            cbWebRtcCustomize.AutoSize = true;
            cbWebRtcCustomize.Checked = true;
            cbWebRtcCustomize.CheckState = CheckState.Checked;
            cbWebRtcCustomize.Location = new Point(6, 91);
            cbWebRtcCustomize.Name = "cbWebRtcCustomize";
            cbWebRtcCustomize.Size = new Size(100, 24);
            cbWebRtcCustomize.TabIndex = 0;
            cbWebRtcCustomize.Text = "Customize";
            cbWebRtcCustomize.UseVisualStyleBackColor = true;
            // 
            // tbCanvasNoise
            // 
            tbCanvasNoise.Location = new Point(342, 114);
            tbCanvasNoise.Name = "tbCanvasNoise";
            tbCanvasNoise.Size = new Size(193, 27);
            tbCanvasNoise.TabIndex = 1;
            tbCanvasNoise.Text = "0";
            // 
            // cbbCanvasMode
            // 
            cbbCanvasMode.FormattingEnabled = true;
            cbbCanvasMode.Items.AddRange(new object[] { "Block", "Noise", "Off" });
            cbbCanvasMode.Location = new Point(342, 82);
            cbbCanvasMode.Name = "cbbCanvasMode";
            cbbCanvasMode.Size = new Size(192, 28);
            cbbCanvasMode.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(239, 117);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 0;
            label11.Text = "Canvas Noise";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(239, 86);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 0;
            label10.Text = "Canvas Mode";
            // 
            // tbResolution
            // 
            tbResolution.Location = new Point(342, 53);
            tbResolution.Name = "tbResolution";
            tbResolution.Size = new Size(193, 27);
            tbResolution.TabIndex = 1;
            tbResolution.Text = "1920x1080";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(239, 56);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 0;
            label9.Text = "Resolution";
            // 
            // cbPasswordSaving
            // 
            cbPasswordSaving.AutoSize = true;
            cbPasswordSaving.Checked = true;
            cbPasswordSaving.CheckState = CheckState.Checked;
            cbPasswordSaving.Location = new Point(6, 146);
            cbPasswordSaving.Name = "cbPasswordSaving";
            cbPasswordSaving.Size = new Size(189, 24);
            cbPasswordSaving.TabIndex = 0;
            cbPasswordSaving.Text = "Enable Password Saving";
            cbPasswordSaving.UseVisualStyleBackColor = true;
            // 
            // cbSessionSaving
            // 
            cbSessionSaving.AutoSize = true;
            cbSessionSaving.Checked = true;
            cbSessionSaving.CheckState = CheckState.Checked;
            cbSessionSaving.Location = new Point(6, 116);
            cbSessionSaving.Name = "cbSessionSaving";
            cbSessionSaving.Size = new Size(177, 24);
            cbSessionSaving.TabIndex = 0;
            cbSessionSaving.Text = "Enable Session Saving";
            cbSessionSaving.UseVisualStyleBackColor = true;
            // 
            // cbExtensionsSaving
            // 
            cbExtensionsSaving.AutoSize = true;
            cbExtensionsSaving.Checked = true;
            cbExtensionsSaving.CheckState = CheckState.Checked;
            cbExtensionsSaving.Location = new Point(6, 86);
            cbExtensionsSaving.Name = "cbExtensionsSaving";
            cbExtensionsSaving.Size = new Size(197, 24);
            cbExtensionsSaving.TabIndex = 0;
            cbExtensionsSaving.Text = "Enable Extensions Saving";
            cbExtensionsSaving.UseVisualStyleBackColor = true;
            // 
            // cbHistorySaving
            // 
            cbHistorySaving.AutoSize = true;
            cbHistorySaving.Checked = true;
            cbHistorySaving.CheckState = CheckState.Checked;
            cbHistorySaving.Location = new Point(6, 56);
            cbHistorySaving.Name = "cbHistorySaving";
            cbHistorySaving.Size = new Size(175, 24);
            cbHistorySaving.TabIndex = 0;
            cbHistorySaving.Text = "Enable History Saving";
            cbHistorySaving.UseVisualStyleBackColor = true;
            // 
            // cbEnableGServices
            // 
            cbEnableGServices.AutoSize = true;
            cbEnableGServices.Location = new Point(6, 26);
            cbEnableGServices.Name = "cbEnableGServices";
            cbEnableGServices.Size = new Size(186, 24);
            cbEnableGServices.TabIndex = 0;
            cbEnableGServices.Text = "Enable Google Services";
            cbEnableGServices.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(751, 486);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 52);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FrmProfileManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 545);
            Controls.Add(btnSave);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmProfileManage";
            Text = "Profile Manager";
            Load += FrmProfileManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbUserAgent;
        private Label label3;
        private TextBox tbNotes;
        private Label label2;
        private TextBox tbName;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cbbProxyMode;
        private CheckBox cbProxyEnable;
        private TextBox tbProxyPort;
        private Label label6;
        private TextBox tbUserName;
        private Label label7;
        private TextBox tbProxyHost;
        private Label label5;
        private CheckBox cbUseAuthenticate;
        private TextBox tbPassword;
        private Label label8;
        private GroupBox groupBox3;
        private CheckBox cbSessionSaving;
        private CheckBox cbExtensionsSaving;
        private CheckBox cbHistorySaving;
        private CheckBox cbEnableGServices;
        private GroupBox groupBox4;
        private CheckBox cbWebRtcEnable;
        private TextBox tbCanvasNoise;
        private Label label11;
        private Label label10;
        private TextBox tbResolution;
        private Label label9;
        private Label label12;
        private ComboBox cbbWebRtcMode;
        private CheckBox cbWebRtcFillBaseIp;
        private CheckBox cbWebRtcIpMasking;
        private CheckBox cbWebRtcCustomize;
        private TextBox tbWebRtcLocalIps;
        private Label label14;
        private TextBox tbWebRtcPublicIp;
        private Label label13;
        private Button btnSave;
        private TextBox tbStartUrl;
        private Label label15;
        private ComboBox cbbCanvasMode;
        private CheckBox cbPasswordSaving;
    }
}