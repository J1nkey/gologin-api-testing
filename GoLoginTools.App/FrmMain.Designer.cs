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
            tbGlToken = new TextBox();
            label1 = new Label();
            btnLoadProfiles = new Button();
            contextMenuStripProfile = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).BeginInit();
            contextMenuStripProfile.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreateProfile);
            groupBox1.Location = new Point(756, 12);
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
            dgvProfiles.Location = new Point(12, 138);
            dgvProfiles.MultiSelect = false;
            dgvProfiles.Name = "dgvProfiles";
            dgvProfiles.ReadOnly = true;
            dgvProfiles.RowHeadersWidth = 51;
            dgvProfiles.RowTemplate.Height = 29;
            dgvProfiles.Size = new Size(1038, 300);
            dgvProfiles.TabIndex = 1;
            dgvProfiles.ColumnAdded += dgvProfiles_ColumnAdded;
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
            // btnLoadProfiles
            // 
            btnLoadProfiles.Location = new Point(12, 99);
            btnLoadProfiles.Name = "btnLoadProfiles";
            btnLoadProfiles.Size = new Size(94, 33);
            btnLoadProfiles.TabIndex = 4;
            btnLoadProfiles.Text = "Load";
            btnLoadProfiles.UseVisualStyleBackColor = true;
            btnLoadProfiles.Click += btnLoadProfiles_Click;
            // 
            // contextMenuStripProfile
            // 
            contextMenuStripProfile.ImageScalingSize = new Size(20, 20);
            contextMenuStripProfile.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStripProfile.Name = "contextMenuStripProfile";
            contextMenuStripProfile.Size = new Size(211, 80);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Modify";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(210, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
            Controls.Add(btnLoadProfiles);
            Controls.Add(label1);
            Controls.Add(tbGlToken);
            Controls.Add(dgvProfiles);
            Controls.Add(groupBox1);
            Name = "FrmMain";
            Text = "FrmMain";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).EndInit();
            contextMenuStripProfile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCreateProfile;
        private DataGridView dgvProfiles;
        private TextBox tbGlToken;
        private Label label1;
        private Button btnLoadProfiles;
        private ContextMenuStrip contextMenuStripProfile;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}