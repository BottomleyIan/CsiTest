using CsiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CsiTest.Controllers
{
    public class RandomNumbersController : Controller
    {
        private ApplicationDbContext _context;

        public RandomNumbersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
        // GET: RandomNumbers
        public ActionResult Index()
        {
            return View(_context.RandomNumbers);
        }
    }
}