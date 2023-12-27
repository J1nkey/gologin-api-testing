using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoLoginTools.POCO;
using GoLoginTools.POCO.Enumerables;
using GoLoginTools.Services.Dtos;

namespace GoLoginTools.Services
{
	public static class GoLoginUtils
	{
		public static GLCreateProfile RandomProfile()
		{
			Random rand = new Random();
			GLCreateProfile dto = new GLCreateProfile();
			dto.name = $"TestProfile {rand.NextInt64()}";
			dto.startUrl = "https://facebook.com/";
			dto.notes = $"No note anything {rand.NextInt64()}";
			dto.browserType = "chrome";
			dto.os = "win";
			dto.GoogleServiceEnabled = false;
			dto.lockEnabled = false;
			dto.debugMode = false;


			NavigatorModel navigator = new NavigatorModel();
			navigator.userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.6045.33 Safari/537.36";
			navigator.resolution = "1920x1080";
			navigator.platform = "Win32";
			dto.navigator = navigator;

			dto.canvas = new CanvasModel() { mode = CanvasMode.off.ToString() };
			dto.audioContext = new AudioContextModel() { Mode = AudioContextMode.off };
			dto.webGL = new WebGlModel() { mode = WebGlMode.off.ToString() };
			dto.webGLMetadata = new WebGlMetadataModel() { 
				mode = WebGlMetadataMode.mask.ToString(), 
				vendor = "Google Inc. (Intel)", 
				renderer = "ANGLE (Intel, Intel(R) HD Graphics 4000 Direct3D11 vs_5_0 ps_5_0, D3D11)"
			};
			dto.storage = new StorageModel()
			{
				local = true,
				extensions = true,
				bookMarks = true,
				history = true,
				passwords = true,
				session = true,
			};

			dto.plugins = new PluginsModel()
			{
				enableVulnerable = true
			};
			dto.proxyEnable = false;
			dto.proxy = new ProxyModel() 
			{
				mode = "none"
			};
			dto.fonts = new FontsModel()
			{
				enableDomRect = true,
				enableMasking = true,
				families = new string[] {"arial", "times new roman"}
			};

			return dto;
		}
	}
}
