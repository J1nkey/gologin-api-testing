﻿
namespace GoLoginTools.Services.Dtos
{
	public class BaseHttpResponse
	{
        public int statusCode { get; set; }
        public string error { get; set; }
        public string message { get; set; }
    }
}
