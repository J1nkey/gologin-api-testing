using GoLoginTools.POCO;
using GoLoginTools.POCO.UIs;
using GoLoginTools.Services;
using GoLoginTools.Services.GoLogin.HttpModels;
using GoLoginTools.Utils;

namespace GoLoginTools.App
{
    public partial class FrmProfileManage : Form
    {
        private readonly GoLoginAPI _glAPI;
        private readonly string _selectedProfileId;
        private readonly bool _isSetting;

        private string[] _profileSettingFonts;
        public FrmProfileManage(string profileId)
        {
            InitializeComponent();

            _selectedProfileId = profileId;
            _isSetting = string.IsNullOrEmpty(profileId) ? false : true;
            _glAPI = new GoLoginAPI(ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN));
        }

        private async void FrmProfileManage_Load(object sender, EventArgs e)
        {
            if (_isSetting)
            {
                var profile = await _glAPI.GetProfileByIdAsync(new GetProfileByIdRequest() { Id = _selectedProfileId });
                tbName.Text = profile.name;
                tbNotes.Text = profile.notes;
                tbStartUrl.Text = profile.startUrl;


                tbUserAgent.Text = profile.navigator.userAgent;
                tbResolution.Text = profile.navigator.resolution;
                tbPlatform.Text = profile.os;

                // canvas settings
                var canvasMode = (profile.canvas.mode[0]).ToString().ToUpper() + profile.canvas.mode.Substring(1);
                cbbCanvasMode.Text = cbbCanvasMode.Items[cbbCanvasMode.Items.IndexOf(canvasMode)].ToString();
                tbCanvasNoise.Text = ((int)profile.canvas.noise).ToString();

                // storage settings
                cbExtensionsSaving.Checked = profile.storage.extensions;
                cbHistorySaving.Checked = profile.storage.history;
                cbPasswordSaving.Checked = profile.storage.passwords;
                cbSessionSaving.Checked = profile.storage.session;
                cbEnableGServices.Checked = profile.googleServiceEnabled;

                // WebRTC settings
                var webRtcMode = (profile.webRTC.mode[0]).ToString().ToUpper() + profile.webRTC.mode.Substring(1);
                cbbWebRtcMode.Text = cbbWebRtcMode.Items[cbbWebRtcMode.Items.IndexOf(webRtcMode)].ToString();
                cbWebRtcEnable.Checked = profile.webRTC.enabled;
                cbWebRtcFillBaseIp.Checked = profile.webRTC.fillBasedOnIp;
                cbWebRtcCustomize.Checked = profile.webRTC.customize;
                cbWebRtcIpMasking.Checked = profile.webRTC.localIPMasking;

                // proxy settings
                cbProxyEnable.Checked = profile.proxyEnable;
                var proxyMode = profile.proxy.mode.ToUpper();
                cbbProxyMode.Text = cbbProxyMode.Items[cbbProxyMode.Items.IndexOf(proxyMode)].ToString();
                tbProxyHost.Text = profile.proxy.host == "null" ? "" : profile.proxy.host;
                tbProxyPort.Text = profile.proxy.port.ToString() == "80" ? "" : profile.proxy.port.ToString();
                tbUserName.Text = profile.proxy.userName;
                tbPassword.Text = profile.proxy.password;

                // fonts settings
                _profileSettingFonts = profile.fonts.families;

                // WebGL settings
                tbWebGLRenderer.Text = profile.webGLMetadata.renderer;
                tbWebGLVendor.Text = profile.webGLMetadata.vendor;
                cbbWebGLMode.Text = cbbWebGLMode.Items[cbbWebGLMode.Items.IndexOf(profile.webGLMetadata.mode)].ToString();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ValidationResult isValidationPassed = ValidateFormData();

            if (!isValidationPassed.IsSuccess)
            {
                MessageBox.Show(isValidationPassed.Message ?? $"Invalid {isValidationPassed.Agent}", "Error!!", MessageBoxButtons.OK);
                return;
            }

            if (!_isSetting)
            {
                CreateNewProfileRequest request = new();
                request.name = tbName.Text.Trim();
                request.notes = tbNotes.Text.Trim();
                request.startUrl = tbStartUrl.Text.Trim();

                if (cbProxyEnable.Checked)
                {
                    request.proxyEnable = true;
                    var proxy = new ProxyModel()
                    {
                        host = tbProxyHost.Text.Trim(),
                        port = int.Parse(tbProxyPort.Text.Trim())
                    };

                    if (cbUseAuthenticate.Checked)
                    {
                        proxy.isAuthenticateRequire = true;
                        proxy.userName = tbUserName.Text.Trim();
                        proxy.password = tbPassword.Text.Trim();
                    }

                    request.proxy = proxy;
                }
                else
                {
                    request.proxyEnable = false;
                    request.proxy = new ProxyModel();
                }

                request.storage = new StorageModel
                {
                    extensions = cbExtensionsSaving.Checked,
                    history = cbHistorySaving.Checked,
                    passwords = cbPasswordSaving.Checked,
                    session = cbSessionSaving.Checked,
                };
                request.navigator = new NavigatorModel
                {
                    userAgent = tbUserAgent.Text.Trim(),
                    resolution = tbResolution.Text.Trim(),
                    platform = tbPlatform.Text.ToLower().Trim()
                };
                request.canvas = new CanvasModel
                {
                    mode = cbbCanvasMode.Text.ToLower().Trim(),
                    noise = int.Parse(tbCanvasNoise.Text.Trim())
                };
                request.webGL = new WebGlModel()
                {
                    mode = "noise",
                    getClientRectNoise = 0,
                    noise = 0
                };

                (string, string) webGlMetadata = RandomService.GetRandomWebGL();
                request.webGLMetadata = new WebGlMetadataModel()
                {
                    vendor = tbWebGLVendor.Text ?? webGlMetadata.Item1,
                    renderer = tbWebGLRenderer.Text ?? webGlMetadata.Item2,
                    mode = cbbWebGLMode.SelectedItem.ToString().ToLower()
                };

                List<string> fontList = LocalFileService.readAllLinesTextFile(Environment.CurrentDirectory + @"\Resources\fonts.txt").ToList();
                int randomFontQuantities = new Random().Next(100, fontList.Count - 1);
                fontList = fontList.Skip(0).Take(randomFontQuantities).ToList();

                request.fonts = new FontsModel()
                {
                    enableDomRect = true,
                    enableMasking = true,
                    families = fontList.ToArray()
                };

                var result = await _glAPI.CreateNewProfileAsync(request);
                if (result != null)
                {
                    if (result.statusCode < 300) // successful code
                    {
                        MessageBox.Show("Create profile successfully!", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        // Handle write log below
                        MessageBox.Show("Create profile failure, please checking the logs in Log directory to see detail error!", "Alert!", MessageBoxButtons.OKCancel);
                        return;
                    }
                }
                MessageBox.Show("Create profile failure!", "Alert!", MessageBoxButtons.OKCancel);
            }
            else
            {
                UpdateProfileRequest updatedObj = new();
                updatedObj.id = _selectedProfileId;
                updatedObj.name = tbName.Text.Trim();
                updatedObj.notes = tbNotes.Text.Trim();
                updatedObj.startUrl = tbStartUrl.Text.Trim();
                updatedObj.os = tbPlatform.Text.ToLower().Trim();

                updatedObj.googleServicesEnabled = cbEnableGServices.Checked;

                // proxy
                if (cbProxyEnable.Checked)
                {
                    updatedObj.proxyEnable = cbProxyEnable.Checked;
                    updatedObj.proxy = new ProxyModel()
                    {
                        host = tbProxyHost.Text.Trim(),
                        port = int.Parse(tbProxyPort.Text.Trim())
                    };

                    if (cbUseAuthenticate.Checked)
                    {
                        updatedObj.proxy.isAuthenticateRequire = cbUseAuthenticate.Checked;
                        updatedObj.proxy.userName = tbUserName.Text.Trim();
                        updatedObj.proxy.password = tbPassword.Text.Trim();
                    }
                }
                else
                {
                    updatedObj.proxy = new ProxyModel();
                    updatedObj.proxyEnable = false;
                }

                // storage
                updatedObj.storage = new StorageModel
                {
                    extensions = cbExtensionsSaving.Checked,
                    history = cbHistorySaving.Checked,
                    passwords = cbPasswordSaving.Checked,
                    session = cbSessionSaving.Checked,
                };

                // navigator
                updatedObj.navigator = new NavigatorModel
                {
                    userAgent = tbUserAgent.Text.Trim(),
                    resolution = tbResolution.Text.Trim(),
                    platform = tbPlatform.Text.ToLower().Trim()
                };

                // canvas
                updatedObj.canvas = new CanvasModel
                {
                    mode = cbbCanvasMode.Text.ToLower().Trim(),
                    noise = int.Parse(tbCanvasNoise.Text.Trim())
                };

                updatedObj.webRTC = new WebRTCModel()
                {
                    enabled = cbWebRtcEnable.Checked,
                    mode = cbbWebRtcMode.Text.ToLower().Trim(),
                    customize = cbWebRtcCustomize.Checked,
                    fillBasedOnIp = cbWebRtcFillBaseIp.Checked,
                    localIPMasking = cbWebRtcIpMasking.Checked
                };
                updatedObj.webGLMetadata = new WebGlMetadataModel
                {
                    mode = cbbWebGLMode.SelectedItem.ToString().ToLower(),
                    renderer = tbWebGLRenderer.Text,
                    vendor = tbWebGLVendor.Text
                };
                updatedObj.fonts = new FontsModel
                {
                    enableDomRect = true,
                    enableMasking = true,
                    families = _profileSettingFonts
                };

                var result = await _glAPI.UpdateProfileAsync(updatedObj);

                if (result.statusCode < 300)
                {
                    MessageBox.Show("Updated profile successfully!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show(result.message, "Alert", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private ValidationResult ValidateFormData()
        {
            ValidationResult result = new();

            if (tbName.Text.Length < 0 || tbName.Text.Length > 255)
            {
                result.IsSuccess = false;
                result.Agent = "Name";
                return result;
            }

            if (cbProxyEnable.Checked == true)
            {
                if (string.IsNullOrEmpty(tbProxyHost.Text) || string.IsNullOrEmpty(tbProxyPort.Text))
                {
                    result.IsSuccess = false;
                    result.Agent = "Host,Port";
                    return result;
                }
                if (!int.TryParse(tbProxyPort.Text, out _))
                {
                    result.IsSuccess = false;
                    result.Agent = "Port";
                    result.Message = "Invalid port number";
                    return result;
                }
            }

            //if (string.IsNullOrEmpty(tbUserAgent.Text))
            //{
            //    result.IsSuccess = false;
            //    result.Agent = "Port";
            //    result.Message = "User agent must not null or empty";
            //    return result;
            //}

            if (!int.TryParse(tbCanvasNoise.Text, out _))
            {
                result.IsSuccess = false;
                result.Agent = "Canvas noise";
                result.Message = "Invalid canvas noise";
                return result;
            }

            result.IsSuccess = true;
            result.Message = "All validation processes passed!";
            return result;
        }

        private void labelWebGlGenerateRandom_Click(object sender, EventArgs e)
        {
            (string, string) webGlMetadata = RandomService.GetRandomWebGL();
            tbWebGLVendor.Text = webGlMetadata.Item1;
            tbWebGLRenderer.Text = webGlMetadata.Item2;
        }
    }
}
