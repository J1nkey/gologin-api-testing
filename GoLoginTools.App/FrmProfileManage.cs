using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoLoginTools.POCO;
using GoLoginTools.POCO.UIs;
using GoLoginTools.Services;
using GoLoginTools.Services.GoLogin.Dtos.CreateNewProfile;
using GoLoginTools.Utils;

namespace GoLoginTools.App
{
	public partial class FrmProfileManage : Form
	{
		private readonly GoLoginAPI _glAPI;
		public FrmProfileManage()
		{
			_glAPI = new GoLoginAPI(ConfigurationService.ReadSetting(ConfigurationKeyCenter.GO_LOGIN_ACCESS_TOKEN));
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ValidationResult isValidationPassed = ValidateFormData();

			if (!isValidationPassed.IsSuccess)
			{
				MessageBox.Show(isValidationPassed.Message ?? $"Invalid {isValidationPassed.Agent}", "Error!!", MessageBoxButtons.OK);
				return;
			}

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
			};
			request.canvas = new CanvasModel
			{
				mode = cbbCanvasMode.Text.Trim(),
				noise = int.Parse(tbCanvasNoise.Text.Trim())
			};

			var result = _glAPI.CreateNewProfileAsync(request).GetAwaiter().GetResult();
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

			if (string.IsNullOrEmpty(tbUserAgent.Text))
			{
				result.IsSuccess = false;
				result.Agent = "Port";
				result.Message = "User agent must not null or empty";
				return result;
			}

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
	}
}
