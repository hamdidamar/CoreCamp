using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new BlogDal());
        public IActionResult Index()
        {
            var blogs = blogManager.GetAll().Data;
            return View(blogs);
        }
    }
}
