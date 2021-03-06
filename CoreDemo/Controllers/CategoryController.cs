using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoryManager cm = new (new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
    }
}
