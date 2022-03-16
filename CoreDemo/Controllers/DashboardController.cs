using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        readonly BlogManager bm = new(new EfBlogRepository());

        public IActionResult Index()
        {
            Context c = new ();
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Blogs.Where(x=>x.BlogId==1).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
