using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CibertecWeb.Model;

namespace CibertecWeb.Controllers
{
    public class OrderController : Controller
    {

        private readonly NorthwindDbContext _db;
        public OrderController(NorthwindDbContext db)
        {

            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Orders);
        }
    }
}