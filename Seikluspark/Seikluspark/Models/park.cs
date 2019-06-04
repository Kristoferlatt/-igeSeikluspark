using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seikluspark.Models
{
    public class park
    {
        public int Id { get; set; }
        public int inimesed { get; set; }
        public int käepaelad { get; set; }
        public int osta { get; set; }
    }
}