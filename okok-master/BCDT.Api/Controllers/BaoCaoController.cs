using Bussiness.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace BCDT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaoCaoController : ControllerBase
    {
        private readonly IBaoCaoService _baocCaoService;
        public BaoCaoController(IBaoCaoService baocCaoService)
        {
            _baocCaoService = baocCaoService;
        }
        [HttpGet]
        //[Authorize]
        public async Task<ActionResult> Get()
        {
            return new ResponseResult(HttpStatusCode.OK, await _baocCaoService.GetAll());
        }
    }
}

