using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Krish.Models
{
    public class Draw
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public string ANumber { get; set; }
        public bool IsAwarded { get; set; }
    }
}