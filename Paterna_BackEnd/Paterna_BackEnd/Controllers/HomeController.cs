using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Paterna_BackEnd.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Paterna_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context { get; }
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services);
        }


    }
}
