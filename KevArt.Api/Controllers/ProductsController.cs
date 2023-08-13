using Microsoft.AspNetCore.Mvc;

namespace KevArt.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts() {
            return "This will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "This will return a product";
        }
    }
}
