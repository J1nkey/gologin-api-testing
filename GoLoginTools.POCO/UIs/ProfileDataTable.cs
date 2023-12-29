using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLoginTools.POCO.UIs
{
	public class ProfileDataTable
	{
        public string Id { get; set; }
        public string Name { get; set; }
        public string OS { get; set; }
        public bool ProxyEnable { get; set; }
        public string ProxyHost { get; set; }
        public string ProxyPort { get; set; }
        public bool WebRTCEnable { get; set; }
        public int MyProperty { get; set; }
    }
}
