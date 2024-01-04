using Microsoft.AspNetCore.Mvc;
using OnlineShop.Api.Filters;

namespace OnlineShop.Api.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiResultFilter]
    [ApiController]
    
    public class BaseController : ControllerBase
    {

    }
}
