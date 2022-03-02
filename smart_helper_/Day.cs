using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_helper_
{
    internal class Day
    {
        public String activity { get; }
        public String date { get; }
        public String transportation { get; }
        public bool coffee { get; }

        public Day(String activity, String date, String transportation, bool coffee)
        {
            this.activity = activity;
            this.date = date;
            this.transportation = transportation;
            this.coffee = coffee;
        }
    }
}
