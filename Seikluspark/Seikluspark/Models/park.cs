using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seikluspark.Models
{
    public class park
    {
        [Range(1, 5)]
        [Required]
        public int inimesed { get; set; }
        [Range(1, 5)]
        [Required]
        public int käepaelad { get; set; }
        
        public int Id { get; set; }
        
        
    }
}