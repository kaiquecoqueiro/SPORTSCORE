using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR.KAIQUE.SPORTSCORE.Models
{
    public class Fan
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Team { get; set; }
    }
}
