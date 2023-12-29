using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoLoginTools
{
	public partial class FrmProfileManage : Form
	{
		public FrmProfileManage()
		{
			InitializeComponent();
		}

		#region UI Events
		private void cbProxy_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox caller = (CheckBox)sender;
			if(caller.Checked)
			{
				tbProxyHost.Enabled = true;
				tbProxyPort.Enabled = true;
				cbbProxyMode.Enabled = true;
			}
			else
			{
				tbProxyHost.Enabled = false;
				tbProxyPort.Enabled = false;
				cbbProxyMode.Enabled = false;
			}
		}

		private void cbUseAuthenticate_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox caller = (CheckBox)sender;
			if(caller.Checked)
			{
				tbUsername.Enabled = true;
				tbPassword.Enabled = true;
			}
			else
			{
				tbUsername.Enabled= false;
				tbPassword.Enabled= false;
			}
		}

		private void cbEnableWebRtc_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox caller = (CheckBox)sender;
			if(caller.Checked)
			{
				cbWebRtcCustomize.Enabled = true;
				cbWebRtcIpMasking.Enabled = true;
				cbWebRtcFillBaseIP.Enabled = true;
				tbWebRtcPublicIp.Enabled = true;
				tbWebRtcLocalIps.Enabled = true;
			}
			else
			{
				cbWebRtcCustomize.Enabled = false;
				cbWebRtcIpMasking.Enabled = false;
				cbWebRtcFillBaseIP.Enabled = false;
				tbWebRtcPublicIp.Enabled = false;
				tbWebRtcLocalIps.Enabled = false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}
		#endregion


	}
}
