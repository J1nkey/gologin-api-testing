﻿using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.Dtos.GetProfilesPaging
{
	public class ProfileDto
	{
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string os { get; set; }
        public bool canBeRunning { get; set; }
        public bool proxyEnable { get; set; }
        public ProxyModel proxy { get; set; }
    }
}
