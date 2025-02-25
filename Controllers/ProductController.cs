using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth5.Controllers
{
    [Authorize]
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("list")]
        public IActionResult GetProducts()
        {
            return Ok(new { Message = "Danh sách sản phẩm" });
        }
    }
}
