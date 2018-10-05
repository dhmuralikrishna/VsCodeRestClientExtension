using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Models;
using System.Collections.Generic;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IEnumerable<Product> Get()
        {
            return ProductRepository.Products; 
        }

        [HttpPost]
        public int Post(Product product)
        {
            int count = ProductRepository.Products.Count;

            ProductRepository.Products.Add(product);

            return count + 1;
        }

    }
}