
using BLL.JwtHelpers;
using Bussiness.IService;
using Common.Request.Auth;
using Common.Response.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;
using System.Text;
using UnitOfWork.Dapper;
using UnitOfWork.UnitOfWork.Interface;

namespace Bussiness.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWorkEF _unitOfWorkEF;
        private readonly IUnitOfWorkDapper _unitOfWorkDapper;
        private readonly IConfiguration _configuration;
        public AuthService(IUnitOfWorkEF unitOfWorkEF, IUnitOfWorkDapper unitOfWorkDapper, IConfiguration configuration)
        {
            this._unitOfWorkEF = unitOfWorkEF;
            this._unitOfWorkDapper = unitOfWorkDapper;
            this._configuration = configuration;
        }
        public TokenResponseModel GeneralJWTToken(VerifyTokenModel model)
        {
            var token = new JwtTokenBuilder()
                               .AddSecurityKey(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration.GetSection("JwtOptions:Secret").Value)))
                               .AddSubject("UserName")
                               .AddIssuer(_configuration["JwtOptions:Issuer"])
                               .AddAudience(_configuration["JwtOptions:Audience"])
                               .AddClaim(ClaimTypes.Name, "UserName")
                               .AddClaim(ClaimTypes.Email, "Email")
                               .AddRole("Example")
                               .AddExpiryInMinutes(Int32.Parse(_configuration["TokenLifespan:JWTExpired"]))
                               .Build();
            return new TokenResponseModel() { AccessToken = token.Value };
        }
    }
}
