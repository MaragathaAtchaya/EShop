//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using onlineshop.Errors;

namespace onlineshop.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi =true)]
    public class ErrorController:BaseOnlineShopController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
