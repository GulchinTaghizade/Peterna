using Paterna_BackEnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paterna_BackEnd.Servicess
{
    public class SettingService
    {
        private ApplicationDbContext _context { get; }
        public SettingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Dictionary<string, string> GetAllSettings()
        {
            return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
