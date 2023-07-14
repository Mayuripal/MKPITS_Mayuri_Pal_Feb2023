using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProduct.Models;

namespace WebApiProduct.Controllers
{
    public class ProductController : ApiController
    {
        //creating an array of Product class
        Product[] products=new Product[]
        {
            new Product{ProductId=1,ProductName="Mouse",ProductPrice=260,Quantity=50},
            new Product{ProductId=2,ProductName="Keyboard",ProductPrice=800,Quantity=10},
            new Product{ProductId=3,ProductName="TV",ProductPrice=7300,Quantity=34},
            new Product{ProductId=4,ProductName="Laptop",ProductPrice=56500,Quantity=42},
            new Product{ProductId=5,ProductName="NoteBook",ProductPrice=40,Quantity=31},
        };
        [HttpGet]
        public IEnumerable<Product> GetAllProducts() 
        { 
            return products;
        }  

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) =>p.ProductId == id);
            if (product == null)
            {
               return NotFound();
            }
            return Ok(product);
        }
    }
}
