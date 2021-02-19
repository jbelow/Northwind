using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Model;
using System.Linq;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        
        
        public IActionResult Category() => View();
    }
}