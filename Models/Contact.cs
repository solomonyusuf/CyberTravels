using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CyberTravels.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string phoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

    }
}
