using System;

namespace Common.Request.Auth
{
    public class VerifyTokenModel
    {
        public string AccessToken { get; set; }
        public Guid AppId { get; set; }
    }
}
