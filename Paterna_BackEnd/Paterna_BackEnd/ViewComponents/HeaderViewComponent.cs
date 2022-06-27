using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paterna_BackEnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paterna_BackEnd.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private ApplicationDbContext _context { get; }
        public HeaderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            return View(model);
        }
    }
}
