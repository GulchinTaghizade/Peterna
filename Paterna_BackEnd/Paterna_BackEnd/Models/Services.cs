using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paterna_BackEnd.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
