using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberTravels.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string CouDestination { get; set; }
        public string LocDestination { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public string Duration { get; set; }
        public string Members { get; set; }
    }
}
