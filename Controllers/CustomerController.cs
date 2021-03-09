using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Model;
using System.Linq;

namespace Northwind.Controllers
{
    public class CustomerController : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public CustomerController(NorthwindContext db) => _northwindContext = db;

        public ActionResult Register() => View();
    }
}
