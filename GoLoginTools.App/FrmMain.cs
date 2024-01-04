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

        private GoLoginAPI _glService = new GoLoginAPI();
        public FrmMain()
        {
            InitializeComponent();
            LoadVariables();
        }

        private void LoadVariables()
        {
            tbGlToken.Text = ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN);
            _glService = new GoLoginAPI(ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN));
        }

        private async Task LoadDataGridViewContent()
        {
            _profiles = await GetDataFromLocal();
            if (_profiles == null)
                _profiles = new List<ProfileDataTable>();

            _dgvDataSource = ConvertToDataTable(_profiles);
            dgvProfiles.DataSource = _dgvDataSource;
            dgvProfiles.Refresh();
        }

        private async Task<List<ProfileDataTable>> GetDataFromLocal()
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + FileStoragePathCenter.PROFILES_CONFIG_PATH))
                {
                    var fileContent = LocalFileService
                                .readAllTextFile(
                                Environment.CurrentDirectory + FileStoragePathCenter.PROFILES_CONFIG_PATH);
                    var data = JsonConvert.DeserializeObject<List<ProfileDataTable>>(fileContent);
                    return data;
                }
                else
                {
                    var profiles = await _glService.GetProfilesPagingAsync(new GetProfilesPagingRequest());
                    if (profiles.statusCode > 300)
                    {
                        MessageBox.Show(profiles.message, "Error!!!", MessageBoxButtons.OK);
                        return new List<ProfileDataTable>();
                    }
                    var data = new List<ProfileDataTable>();
                    foreach (var profile in profiles.Profiles)
                    {
                        ProfileDataTable sample = new()
                        {
                            Id = profile.id,
                            Name = profile.name,
                            OS = profile.os,
                            ProxyEnable = profile.proxyEnable
                        };
                        if (profile.proxy != null)
                        {
                            sample.ProxyHost = profile.proxy.host;
                            sample.ProxyPort = profile.proxy.port;
                        }
                        data.Add(sample);
                    }

                    return data;
                }
            }
            catch
            {
                return new List<ProfileDataTable>();
            }

        }
        private void RefreshList()
        {
            var current = GetDataFromLocal().GetAwaiter().GetResult();
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

            if (!string.IsNullOrEmpty(tbGlToken.Text))
            {
                _glService.SetAccessToken(tbGlToken.Text);
            }
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
            lock (_dgvDataSource)
            {
                _dgvDataSource.Rows.InsertAt(row, position);
            }
            return row;
        }

        private async void btnLoadProfiles_Click(object sender, EventArgs e)
        {
            await LoadDataGridViewContent();
        }

        private void dgvProfiles_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            e.Column.HeaderText = e.Column.Name.Replace("cl_", "");
            if (e.Column.Name == "cl_Index" || e.Column.Name == "cl_OS" || e.Column.Name == "cl_ProxyEnable")
            {
                e.Column.Width = 60;
                e.Column.MinimumWidth = 60;
                return;
            }
            if (e.Column.Name == "cl_Id")
            {
                e.Column.Width = 125;
                e.Column.MinimumWidth = 125;
                return;
            }
            if (e.Column.Name == "cl_Name")
            {
                e.Column.Width = 200;
                e.Column.MinimumWidth = 125;
                e.Column.HeaderText = "HTTP Proxy";
                //e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                return;
            }
            if (e.Column.Name == "cl_Proxy")
            {
                e.Column.Width = 100;
                e.Column.MinimumWidth = 90;
                e.Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                return;
            }
        }
        #endregion


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowIndex = dgvProfiles.SelectedRows[0].Index;
            var profileId = dgvProfiles.Rows[rowIndex].Cells["cl_Id"].Value.ToString();
            FrmProfileManage frmManage = new FrmProfileManage(profileId);
            frmManage.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var userSelect = MessageBox.Show("Are you sure to delete this profile?", "Alert", MessageBoxButtons.OKCancel);
            if(userSelect == DialogResult.OK)
            {
                //
            }
        }
    }
}
