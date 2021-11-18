using System;
using System.IdentityModel.Tokens.Jwt;

namespace Common.Response.Auth
{
    public class TokenResponseModel
    {
        public string AccessToken { get; set; }
    }

    public sealed class JwtToken
    {
        private readonly JwtSecurityToken token;

        internal JwtToken(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime ValidTo => token.ValidTo;
        public string Value => new JwtSecurityTokenHandler().WriteToken(this.token);
    }
}
