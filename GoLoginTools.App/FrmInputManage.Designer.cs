namespace GoLoginTools.App
{
    partial class FrmInputManage
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
            tbInput = new TextBox();
            lbFormatTitle = new Label();
            lbFormat = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(12, 63);
            tbInput.Multiline = true;
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(776, 375);
            tbInput.TabIndex = 0;
            // 
            // lbFormatTitle
            // 
            lbFormatTitle.AutoSize = true;
            lbFormatTitle.Location = new Point(12, 22);
            lbFormatTitle.Name = "lbFormatTitle";
            lbFormatTitle.Size = new Size(59, 20);
            lbFormatTitle.TabIndex = 1;
            lbFormatTitle.Text = "Format:";
            // 
            // lbFormat
            // 
            lbFormat.AutoSize = true;
            lbFormat.Location = new Point(77, 22);
            lbFormat.Name = "lbFormat";
            lbFormat.Size = new Size(56, 20);
            lbFormat.TabIndex = 2;
            lbFormat.Text = "Format";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(692, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmInputManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lbFormat);
            Controls.Add(lbFormatTitle);
            Controls.Add(tbInput);
            Name = "FrmInputManage";
            Text = "Input Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInput;
        private Label lbFormatTitle;
        private Label lbFormat;
        private Button btnSave;
    }
}