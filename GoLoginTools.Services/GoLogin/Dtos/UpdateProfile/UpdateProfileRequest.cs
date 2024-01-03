using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.Dtos.UpdateProfile
{
	public class UpdateProfileRequest
	{
        public string id { get; set; }
        public string name { get; set; }
        public string browserType { get; set; }
        public string startUrl { get; set; }
        public bool googleServicesEnabled { get; set; }
        public NavigatorModel navigator { get; set; }
        public ProxyModel proxy { get; set; }
        public TimeZoneModel timezone { get; set; }
        public WebGlModel webGL { get; set; }
        public WebGlMetadataModel webGLMetadata { get; set; }
        public WebRTCModel webRTC { get; set; }

    }
}
