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
			groupBox1 = new GroupBox();
			btnCreateProfile = new Button();
			dgvProfiles = new DataGridView();
			tbGlToken = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProfiles).BeginInit();
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
			dgvProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProfiles.Location = new Point(12, 138);
			dgvProfiles.Name = "dgvProfiles";
			dgvProfiles.RowHeadersWidth = 51;
			dgvProfiles.RowTemplate.Height = 29;
			dgvProfiles.Size = new Size(1038, 300);
			dgvProfiles.TabIndex = 1;
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
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1062, 450);
			Controls.Add(label1);
			Controls.Add(tbGlToken);
			Controls.Add(dgvProfiles);
			Controls.Add(groupBox1);
			Name = "FrmMain";
			Text = "FrmMain";
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvProfiles).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Button btnCreateProfile;
		private DataGridView dgvProfiles;
		private TextBox tbGlToken;
		private Label label1;
	}
}