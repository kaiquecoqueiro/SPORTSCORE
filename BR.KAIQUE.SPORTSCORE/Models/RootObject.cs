using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BR.KAIQUE.SPORTSCORE.Models
{
    public class Filters
    {
        public List<int> areas { get; set; }
    }

    public class Area
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public Area area { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public int? founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public Filters filters { get; set; }
        public List<Team> teams { get; set; }
    }
}
