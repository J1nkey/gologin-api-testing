namespace GoLoginTools
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
			this.btnCreateNew = new System.Windows.Forms.Button();
			this.grbProfiles = new System.Windows.Forms.GroupBox();
			this.dgvAvailableProfiles = new System.Windows.Forms.DataGridView();
			this.grbProfiles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProfiles)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreateNew
			// 
			this.btnCreateNew.Location = new System.Drawing.Point(6, 21);
			this.btnCreateNew.Name = "btnCreateNew";
			this.btnCreateNew.Size = new System.Drawing.Size(90, 37);
			this.btnCreateNew.TabIndex = 0;
			this.btnCreateNew.Text = "Create";
			this.btnCreateNew.UseVisualStyleBackColor = true;
			// 
			// grbProfiles
			// 
			this.grbProfiles.Controls.Add(this.btnCreateNew);
			this.grbProfiles.Location = new System.Drawing.Point(12, 12);
			this.grbProfiles.Name = "grbProfiles";
			this.grbProfiles.Size = new System.Drawing.Size(361, 75);
			this.grbProfiles.TabIndex = 1;
			this.grbProfiles.TabStop = false;
			this.grbProfiles.Text = "Profiles";
			// 
			// dgvAvailableProfiles
			// 
			this.dgvAvailableProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAvailableProfiles.Location = new System.Drawing.Point(12, 147);
			this.dgvAvailableProfiles.Name = "dgvAvailableProfiles";
			this.dgvAvailableProfiles.RowHeadersWidth = 51;
			this.dgvAvailableProfiles.RowTemplate.Height = 24;
			this.dgvAvailableProfiles.Size = new System.Drawing.Size(1044, 241);
			this.dgvAvailableProfiles.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 393);
			this.Controls.Add(this.dgvAvailableProfiles);
			this.Controls.Add(this.grbProfiles);
			this.Name = "Form1";
			this.Text = "Form1";
			this.grbProfiles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProfiles)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreateNew;
		private System.Windows.Forms.GroupBox grbProfiles;
		private System.Windows.Forms.DataGridView dgvAvailableProfiles;
	}
}

