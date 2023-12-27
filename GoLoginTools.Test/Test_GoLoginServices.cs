using GoLoginTools.Services;
using GoLoginTools.Services.Dtos.GetProfilesPaging;

namespace GoLoginTools.Test
{
	[TestClass]
	public class Test_GoLoginServices
	{
		private string _accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI2NThhOTdlMDgwNDAxMjZkYzAxNDdiNmEiLCJ0eXBlIjoiZGV2Iiwiand0aWQiOiI2NThhOWI5MGY0Y2QzYWNhOWZhNTY2NjkifQ.VKCW2u0iGCrVlDjlGCv-b3kyHBKAG5s_wOjVjM3jH6A";
		[TestMethod]
		public void Test_CreateProfile()
		{
			GoLoginAPI api = new GoLoginAPI(_accessToken);
			var isCreated = api.CreateNewProfileAsync(GoLoginUtils.RandomProfile()).GetAwaiter().GetResult();
		}

		[TestMethod]
		public void Test_GetProfilesPaging()
		{
			GoLoginAPI api = new GoLoginAPI(_accessToken);
			var result = api.GetProfilesPagingAsync(new GetProfilesPagingRequest() { Limit = 10, Page = 1 }).GetAwaiter().GetResult();
		}


	}
}