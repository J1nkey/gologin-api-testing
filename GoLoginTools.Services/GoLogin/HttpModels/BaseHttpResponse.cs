
namespace GoLoginTools.Services.GoLogin.HttpModels
{
	public class BaseHttpResponse
	{
        public int statusCode { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }
}
