using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlyy.Models;

namespace Vidlyy.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {

            return View();
        }

        public ViewResult Customer()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

        }
        public ActionResult Details(int id)
        {
           
            var custDetails = _context.Customers.FirstOrDefault(m => m.Id == id);

            if (custDetails == null)
            {
                custDetails = new Customer { Id = 0, Name = "Not Found!" };
            }

            return View(custDetails);
        }
    }
}