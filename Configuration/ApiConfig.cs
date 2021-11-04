using System;

namespace refit_test.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set ; }
        public string InternalUrl { get; set; }
    }
}