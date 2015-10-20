using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        //member vars
        private Product[] m_products = new Product[]
        {
            new Product{Id = 1, Name = "Tomato Paste Can", Category = "Groceries", Price = 1},
            new Product{Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product{Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M},
            new Product{Id = 4, Name = "Air Gun", Category = "Hardware", Price = 86.99M}
        };


        //methods
        public IEnumerable<Product> GetAllProducts()
        {
            return m_products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = m_products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
