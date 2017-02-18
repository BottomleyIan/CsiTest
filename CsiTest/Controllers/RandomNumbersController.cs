using CsiTest.ActionResults;
using CsiTest.Models;
using CsiTest.ViewModels;
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

        public ActionResult Export()
        {
            return new XmlResult(_context.RandomNumbers.ToList());
        }

        public ActionResult New()
        {
            return View(new NewRandomNumbersViewModel());
        }

        [HttpPost]
        public ActionResult Create(NewRandomNumbersViewModel viewModel)
        {
            _context.RandomNumbers.Add(new RandomNumber(viewModel));
            _context.SaveChanges();
            return RedirectToAction("Index", "RandomNumbers");
        }
    }
}