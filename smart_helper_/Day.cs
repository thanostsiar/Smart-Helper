using System;
using System.Collections.Generic;
using System.Drawing;

namespace smart_helper_
{
    public class Day
    {
        public String activity { get; }
        public String date { get; }
        public String transportation { get; }
        public bool coffee { get; }
        public Image route { get; }

        public Day(String activity, String date, String transportation, bool coffee, Image route)
        {
            List<Day> days = new List<Day>();
            this.activity = activity;
            this.date = date;
            this.transportation = transportation;
            this.coffee = coffee;
            this.route = route;
        }
    }
}
