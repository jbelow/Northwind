using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Model;
using System.Linq;

namespace Northwind.Controllers
{
    public class Category : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public Category(NorthwindContext db) => _northwindContext = db;

        public IActionResult Index() => View(_northwindContext.Categories.OrderBy(b => b.CategoryName));
    }
}