using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoLoginTools.POCO.UIs;
using GoLoginTools.Services;
using GoLoginTools.Utils;
using Newtonsoft.Json;

namespace GoLoginTools.App
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
			LoadVariables();
			LoadDataGridViewContent();
		}

		private void LoadVariables()
		{
			tbGlToken.Text = ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN);
		}

		private void LoadDataGridViewContent()
		{
			var content = GetDataFromLocal();
		}

		private IEnumerable<ProfileDataTable> GetDataFromLocal()
		{
			var fileContent = LocalFileService
				.readAllTextFile(
				Environment.CurrentDirectory + FileStoragePathCenter.PROFILES_CONFIG_PATH);

			var data = JsonConvert.DeserializeObject<List<ProfileDataTable>>(fileContent);
			return data;
		}

		#region UI Events
		private void tbGlToken_TextChanged(object sender, EventArgs e)
		{
			ConfigurationService
				.AddUpdateAppSettings(
					ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN,
					tbGlToken.Text
				);
		}

		private void btnCreateProfile_Click(object sender, EventArgs e)
		{
			var profileDialog = new FrmProfileManage();
			profileDialog.ShowDialog();
		}
		#endregion

	}
}
