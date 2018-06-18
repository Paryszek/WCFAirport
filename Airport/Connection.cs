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
        public string Departure { get; set; }
        public string Arrival { get; set; }

        public Connection(string _from, string _to, string _departure, string _arrival)
        {
            From = _from;
            To = _to;
            Departure = _departure;
            Arrival = _arrival;
        }

        public override string ToString()
        {
            return "From: " + From + " to " + To + " " + Departure + "-" + Arrival;
        }
    }
}