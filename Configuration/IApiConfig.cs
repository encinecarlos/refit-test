using System;

namespace refit_test.Configuration
{
    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
        public string InternalUrl { get; set; }
    }
}