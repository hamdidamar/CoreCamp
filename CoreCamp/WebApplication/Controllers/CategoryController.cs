using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        public IActionResult Index()
        {
            var categories = categoryManager.GetAll().Data;
            return View(categories);
        }
    }
}
