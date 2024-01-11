using GoLoginTools.Services;
using GoLoginTools.Services.GoLogin.HttpModels;

namespace GoLoginTools.Test
{
	[TestClass]
	public class Test_GoLoginServices
	{
		private string _accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI2NTk1MjE1NTFlYjQyZmZjMjJkN2U5NzEiLCJ0eXBlIjoiZGV2Iiwiand0aWQiOiI2NTk1MjM2NTljMDQwNDMxYmI1MTYzYjEifQ.Gzth4UtyZd8B4ldKJsJtVdokd8FD_YbHRHRJRK7YL9A";
		private string _browserId = "658c02232f3c3f2c07cde9dd";
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

		[TestMethod]
		public void Test_GetNewFingerprint()
		{
			GoLoginAPI api = new GoLoginAPI(_accessToken);
			var requestObj = new GetNewFingerprintRequest();
			requestObj.os = "win";
			var result = api.GetNewFingerprintAsync(requestObj).Result;
		}

		[TestMethod]
		public void Test_UpdateFingerprint()
		{
			GoLoginAPI api = new GoLoginAPI(_accessToken);
			var requestObj = new UpdateNewFingerprintRequest();
			requestObj.resolution = "1920x1080";
			requestObj.language = "en-US";
			requestObj.browserIds = new[] { _browserId };
			var result = api.UpdateNewFingerprintAsync(requestObj).Result;
		}
	}
}