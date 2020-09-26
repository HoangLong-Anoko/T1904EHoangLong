using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Services;

namespace ProductManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        //[Route("Rate")]
        //[HttpGet]
        //public ActionResult Get(
        //    [FromQuery] string ProductId,
        //    [FromQuery] int Rating)
        //{
        //    ProductService.AddRating(ProductId, Rating);
        //    return Ok();
        //}

        //[HttpPatch]
        //public ActionResult Patch([FromBody] RatingRequest request)
        //{
        //    ProductService.AddRating(request.ProductId, request.Rating);

        //    return Ok();
        //}

        //public class RatingRequest
        //{
        //    public string ProductId { get; set; }
        //    public int Rating { get; set; }
        //}
    }
}
