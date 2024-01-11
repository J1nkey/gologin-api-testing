namespace GoLoginTools.POCO
{
	public class ProxyModel
	{
        public string mode { get; set; } = "none";
        public string host { get; set; }
        public int port { get; set; }
        public bool isAuthenticateRequire { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
