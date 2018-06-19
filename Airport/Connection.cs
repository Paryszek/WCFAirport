using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airport
{
    public class Connection
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public Connection(string _from, string _to, DateTime _departure, DateTime _arrival)
        {
            From = _from;
            To = _to;
            Departure = _departure;
            Arrival = _arrival;
        }

        public override string ToString()
        {
            return "From: " + From + " to " + To + " " + Departure.TimeOfDay + "-" + Arrival.TimeOfDay;
        }
    }
}