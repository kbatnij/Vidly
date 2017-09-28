using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult New()
        {
            return View();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(s=> s.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(s=> s.MembershipType).SingleOrDefault(s => s.Id == Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}