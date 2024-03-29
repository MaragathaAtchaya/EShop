﻿using Microsoft.AspNetCore.Mvc;

namespace onlineshop.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message??GetDefaultMessageForStatusCode(statusCode);

        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Thats a badrequest",
                401 => "You are not Authourized",
                404 => "Resource not found",
                500 => "Internal server error occured, Thanks for you patience",
                _=>null
            };
        }
    }
}
