using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CibertecWeb.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CibertecWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        private readonly NorthwindDbContext _db;
        public CustomerController(NorthwindDbContext db)
        {

            _db = db;
        }

        public IActionResult Index()
        {
            
            return View(_db.Customers);
        }
    }
}
