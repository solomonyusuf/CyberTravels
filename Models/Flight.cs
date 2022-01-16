using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberTravels.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Roundtrip { get; set; }
        public string Onway { get; set; }
        public string From { get; set; }
        public string Depatures { get; set; }
        public string Return { get; set; }
        public string Adults { get; set; }
        public string Childs { get; set; }
        public string To { get; set; }
        public string Class { get; set; }

    }
}
