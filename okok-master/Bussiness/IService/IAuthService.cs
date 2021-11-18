using Common.Request.Auth;
using Common.Response.Auth;

namespace Bussiness.IService
{
    public interface IAuthService
    {
        TokenResponseModel GeneralJWTToken(VerifyTokenModel model);
    }
}
