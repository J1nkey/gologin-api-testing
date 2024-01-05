using GoLoginTools.Services;
using GoLoginTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoLoginTools.App
{
    public partial class FrmInputManage : Form
    {
        private readonly string _inputType;
        private readonly string _saveFilePath;
        private string _allowedFormat;

        public FrmInputManage(string inputType)
        {
            InitializeComponent();

            if (inputType.ToLower() == "email")
            {
                _inputType = "email";
                _saveFilePath = Environment.CurrentDirectory + FileStoragePathCenter.INPUT_EMAIL_PATH;
                _allowedFormat = "<email>|<password>|<recovery-email>|<forward-email>";
            }
            else if (inputType.ToLower() == "proxy")
            {
                _inputType = "email";
                _saveFilePath = Environment.CurrentDirectory + FileStoragePathCenter.INPUT_PROXY_PATH;
                _allowedFormat = "<fake-type>:<host>:<port>:<username>:<password>";
            }

            tbInput.Text = LocalFileService.readAllTextFile(_saveFilePath);
            lbFormat.Text = _allowedFormat;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LocalFileService.writeTextFile(_saveFilePath, tbInput.Text.Trim());
            MessageBox.Show($"Update {_inputType} successfully!", "Notification", MessageBoxButtons.OK);
        }
    }
}
