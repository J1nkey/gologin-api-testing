namespace GoLoginTools.App
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnCreateProfile = new Button();
            dgvProfiles = new DataGridView();
            contextMenuStripProfile = new ContextMenuStrip(components);
            startAutoForwardToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            tbGlToken = new TextBox();
            label1 = new Label();
            btnInputEmail = new Button();
            groupBox2 = new GroupBox();
            btnInputProxy = new Button();
            btnStartAll = new Button();
            btnStopAll = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).BeginInit();
            contextMenuStripProfile.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreateProfile);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profiles";
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.Location = new Point(6, 26);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Size = new Size(94, 36);
            btnCreateProfile.TabIndex = 0;
            btnCreateProfile.Text = "Create";
            btnCreateProfile.UseVisualStyleBackColor = true;
            btnCreateProfile.Click += btnCreateProfile_Click;
            // 
            // dgvProfiles
            // 
            dgvProfiles.AllowUserToAddRows = false;
            dgvProfiles.AllowUserToDeleteRows = false;
            dgvProfiles.AllowUserToResizeColumns = false;
            dgvProfiles.AllowUserToResizeRows = false;
            dgvProfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfiles.ContextMenuStrip = contextMenuStripProfile;
            dgvProfiles.Location = new Point(12, 138);
            dgvProfiles.MultiSelect = false;
            dgvProfiles.Name = "dgvProfiles";
            dgvProfiles.ReadOnly = true;
            dgvProfiles.RowHeadersWidth = 51;
            dgvProfiles.RowTemplate.Height = 29;
            dgvProfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProfiles.Size = new Size(1038, 300);
            dgvProfiles.TabIndex = 1;
            dgvProfiles.CellClick += dgvProfiles_CellClick;
            dgvProfiles.ColumnAdded += dgvProfiles_ColumnAdded;
            // 
            // contextMenuStripProfile
            // 
            contextMenuStripProfile.ImageScalingSize = new Size(20, 20);
            contextMenuStripProfile.Items.AddRange(new ToolStripItem[] { startAutoForwardToolStripMenuItem, modifyToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStripProfile.Name = "contextMenuStripProfile";
            contextMenuStripProfile.Size = new Size(208, 82);
            // 
            // startAutoForwardToolStripMenuItem
            // 
            startAutoForwardToolStripMenuItem.Image = Properties.Resources.start_icon;
            startAutoForwardToolStripMenuItem.Name = "startAutoForwardToolStripMenuItem";
            startAutoForwardToolStripMenuItem.Size = new Size(207, 26);
            startAutoForwardToolStripMenuItem.Text = "Start Auto Forward";
            startAutoForwardToolStripMenuItem.Click += startAutoForwardToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Image = Properties.Resources.modify_icon;
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(207, 26);
            modifyToolStripMenuItem.Text = "Modify";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Image = Properties.Resources.delete_icon;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(207, 26);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem_Click;
            // 
            // tbGlToken
            // 
            tbGlToken.Location = new Point(126, 6);
            tbGlToken.Name = "tbGlToken";
            tbGlToken.Size = new Size(203, 27);
            tbGlToken.TabIndex = 2;
            tbGlToken.TextChanged += tbGlToken_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "GoLogin Token";
            // 
            // btnInputEmail
            // 
            btnInputEmail.Location = new Point(6, 26);
            btnInputEmail.Name = "btnInputEmail";
            btnInputEmail.Size = new Size(89, 38);
            btnInputEmail.TabIndex = 4;
            btnInputEmail.Text = "Email";
            btnInputEmail.UseVisualStyleBackColor = true;
            btnInputEmail.Click += btnInputEmail_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInputProxy);
            groupBox2.Controls.Add(btnInputEmail);
            groupBox2.Location = new Point(326, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 72);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // btnInputProxy
            // 
            btnInputProxy.Location = new Point(101, 26);
            btnInputProxy.Name = "btnInputProxy";
            btnInputProxy.Size = new Size(89, 38);
            btnInputProxy.TabIndex = 4;
            btnInputProxy.Text = "Proxy";
            btnInputProxy.UseVisualStyleBackColor = true;
            btnInputProxy.Click += btnInputProxy_Click;
            // 
            // btnStartAll
            // 
            btnStartAll.BackColor = Color.LimeGreen;
            btnStartAll.ForeColor = Color.White;
            btnStartAll.Location = new Point(956, 6);
            btnStartAll.Name = "btnStartAll";
            btnStartAll.Size = new Size(94, 50);
            btnStartAll.TabIndex = 6;
            btnStartAll.Text = "Start All";
            btnStartAll.UseVisualStyleBackColor = false;
            // 
            // btnStopAll
            // 
            btnStopAll.BackColor = Color.IndianRed;
            btnStopAll.ForeColor = Color.White;
            btnStopAll.Location = new Point(856, 6);
            btnStopAll.Name = "btnStopAll";
            btnStopAll.Size = new Size(94, 50);
            btnStopAll.TabIndex = 6;
            btnStopAll.Text = "Stop All";
            btnStopAll.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
            Controls.Add(btnStopAll);
            Controls.Add(btnStartAll);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(tbGlToken);
            Controls.Add(dgvProfiles);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "Auto Forward Tool";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).EndInit();
            contextMenuStripProfile.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCreateProfile;
        private DataGridView dgvProfiles;
        private TextBox tbGlToken;
        private Label label1;
        private ContextMenuStrip contextMenuStripProfile;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private Button btnInputEmail;
        private GroupBox groupBox2;
        private Button btnInputProxy;
        private Button btnStartAll;
        private Button btnStopAll;
        private ToolStripMenuItem startAutoForwardToolStripMenuItem;
    }
}