using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Model;
using System.Linq;


namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;
        
        //this is the part that says "hey here is what you are routing to" and sends the database info along with it
        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(c => c.CategoryName));

        public IActionResult ProductDisplayList(int id) => View(new ViewProducts
        {
            category = _northwindContext.Categories.FirstOrDefault(c => c.CategoryId == id),
            products = _northwindContext.Products.Where(p => (p.CategoryId == id) &&
					                                         (p.Discontinued == false))
        });

    }
}