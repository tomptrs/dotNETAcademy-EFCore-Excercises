using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_demo2.Controllers
{
    public class MovieController : Controller
    {
        MovieContext context;
        public MovieController(MovieContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
           

            return View();
        }
    }
}