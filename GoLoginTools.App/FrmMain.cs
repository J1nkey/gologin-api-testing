using System.Data;
using GoLoginTools.POCO.UIs;
using GoLoginTools.Services;
using GoLoginTools.Services.GoLogin.Dtos.GetProfilesPaging;
using GoLoginTools.Utils;
using Newtonsoft.Json;

namespace GoLoginTools.App
{
	public partial class FrmMain : Form
	{
		private DataTable _dgvDataSource;
		private List<ProfileDataTable> _profiles;

		private object _lockProfile = new object();
		private object _lockDatatable = new object();

		private GoLoginAPI _glService;
		public FrmMain()
		{
			InitializeComponent();
			LoadVariables();
			LoadDataGridViewContent();
		}

		private void LoadVariables()
		{
			tbGlToken.Text = ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN);
			_glService = new GoLoginAPI(ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN));
		}

		private void LoadDataGridViewContent()
		{
			Task.Run(() =>
			{
				_profiles = GetDataFromLocal();
				if (_profiles == null)
					_profiles = new List<ProfileDataTable>();

				_dgvDataSource = ConvertToDataTable(_profiles);
			})
				.ContinueWith(taskWaitUI =>
				{
					dgvProfiles.DataSource = _dgvDataSource;
				});
		}

		private List<ProfileDataTable> GetDataFromLocal()
		{
			try
			{
				if(File.Exists(Environment.CurrentDirectory + FileStoragePathCenter.PROFILES_CONFIG_PATH))
				{
					var fileContent = LocalFileService
								.readAllTextFile(
								Environment.CurrentDirectory + FileStoragePathCenter.PROFILES_CONFIG_PATH);
					var data = JsonConvert.DeserializeObject<List<ProfileDataTable>>(fileContent);
					return data;
				}
				else
				{
					var profiles = _glService.GetProfilesPagingAsync(new GetProfilesPagingRequest());
				}
			}
			catch
			{
				return new List<ProfileDataTable>();
			}
			
		}
		private void RefreshList()
		{
			var current = GetDataFromLocal();
			//remove item if not found
			for (var i = _profiles.Count - 1; i >= 0; i--)
			{
				if (!current.Any(x => x.Id.Equals(_profiles[i].Id)))
				{
					lock (_lockProfile)
					{
						_profiles.RemoveAt(i);
					}
					lock (_lockDatatable)
					{
						_dgvDataSource.Rows.RemoveAt(i);
					}
				}
			}
			//add new item
			foreach (var newProfile in current)
			{
				if (!_profiles.Any(x => x.Id.Equals(newProfile.Id)))
				{
					lock (_lockProfile)
					{
						_profiles.Add(newProfile);
					}
					var new_index = _profiles.IndexOf(newProfile);
					AddNewRow(newProfile, new_index);
				}
			}
			//re-index
			var index = 1;
			foreach (DataGridViewRow row in dgvProfiles.Rows)
			{
				lock (_lockDatatable)
				{
					_dgvDataSource.Rows[row.Index]["cl_Index"] = index++;
				}
			}
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
			RefreshList();
		}

		private DataTable ConvertToDataTable(ICollection<ProfileDataTable> data)
		{
			var props = typeof(ProfileDataTable).GetProperties().ToList()
				.Select(x => (x.Name, x.PropertyType)).ToList();
			DataTable table = new DataTable();

			//foreach(var prop in props)
			//{
			//	table.Columns.Add($"cl_{prop.Name}", prop.PropertyType);
			//}

			table.Columns.Add("cl_Index", typeof(string));
			table.Columns.Add("cl_Id", typeof(string));
			table.Columns.Add("cl_Name", typeof(string));
			table.Columns.Add("cl_OS", typeof(string));
			table.Columns.Add("cl_ProxyEnable", typeof(string));
			table.Columns.Add("cl_Proxy", typeof(string));
			table.Columns.Add("cl_WebRTCEnable", typeof(string));
			var index = 1;

			foreach (var item in data)
			{
				DataRow row = table.NewRow();
				row["cl_Index"] = index++;
				row["cl_Id"] = item.Id;
				row["cl_Name"] = item.Name;
				row["cl_OS"] = item.OS;
				row["cl_ProxyEnable"] = item.ProxyEnable;
				row["cl_Proxy"] = item.ProxyHost + ":" + item.ProxyPort;
				row["cl_WebRTCEnable"] = item.WebRTCEnable;
				table.Rows.Add(row);
			}

			return table;
		}

		private DataRow AddNewRow(ProfileDataTable data, int position = 0)
		{
			DataRow row = _dgvDataSource.NewRow();
			row["cl_Index"] = _dgvDataSource.Rows.Count + 1;
			row["cl_Id"] = data.Id;
			row["cl_Name"] = data.Name;
			row["cl_OS"] = data.OS;
			row["cl_ProxyEnable"] = data.ProxyEnable;
			row["cl_Proxy"] = data.ProxyHost + ":" + data.ProxyPort;
			row["cl_WebRTCEnable"] = data.WebRTCEnable;
			lock (_dgvDataSource)
			{
				_dgvDataSource.Rows.InsertAt(row, position);
			}
			return row;
		}
		#endregion

	}
}
