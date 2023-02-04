using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlyy.Models;

namespace Vidlyy.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Movie()
        {

            var Movies = _context.Movies.Include(c => c.Genre). ToList();
            return View(Movies);

        }
        public ActionResult MvDetails(int id)
        {
            
            var mv = _context.Movies.Include(c => c.Genre).FirstOrDefault(m => m.Id == id);
            if (mv == null)
            {
                mv = new Movie() { Id = 0, Name = "MovieNotFound!" };
            }
            return View(mv);

        }
    }
}