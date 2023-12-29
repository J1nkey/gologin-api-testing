using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GoLoginTools.Services
{
	public class ConfigurationService
	{
		public static string ReadSetting(string key)
		{
			var appSettings = ConfigurationManager.AppSettings;
			string result = appSettings[key] ?? "Not Found";
			return result;
		} 

		public static bool AddUpdateAppSettings(string key, string value)
		{
			try
			{
				var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				var settings = configFile.AppSettings.Settings;
				if (settings[key] == null)
				{
					settings.Add(key, value);
				}
				else
				{
					settings[key].Value = value;
				}
				configFile.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

				return true;
			}
			catch (ConfigurationErrorsException)
			{
				Console.WriteLine("Error writing app settings");
				return false;
			}
		}
	}
}
