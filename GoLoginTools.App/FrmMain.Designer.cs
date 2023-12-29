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
			dataGridView1 = new DataGridView();
			tbGlToken = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 138);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(1038, 300);
			dataGridView1.TabIndex = 1;
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
			Controls.Add(dataGridView1);
			Controls.Add(groupBox1);
			Name = "FrmMain";
			Text = "FrmMain";
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Button btnCreateProfile;
		private DataGridView dataGridView1;
		private TextBox tbGlToken;
		private Label label1;
	}
}