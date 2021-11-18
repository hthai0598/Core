using Bussiness.IService;
using Common.Request.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace BCDT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [Route("sso")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateToken(VerifyTokenModel model)
        {
            var response = _authService.GeneralJWTToken(model);
            return new ResponseResult(HttpStatusCode.OK, response);
        }
    }
}
