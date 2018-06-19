using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Airport
{
    public class AirportBase
    {
        public List<string> FromCityList { get; private set; }
        public List<string> ToCityList { get; private set; }
        public List<string> DepartureTimeList { get; private set; }
        public List<string> ArrivalTimeList { get; private set; }
        public List<Connection> Connections { get; private set; }
        public AirportBase()
        {
            DepartureTimeList = new List<string>();
            ArrivalTimeList = new List<string>();
            FromCityList = new List<string>();
            ToCityList = new List<string>();
            InitData();
            InitConnections();
        }

        private void InitData()
        {
            using (var reader = new StreamReader("../../../Airport/airport.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(';');
                    FromCityList.Add(data[0]);
                    ToCityList.Add(data[1]);
                    DepartureTimeList.Add(data[2]);
                    ArrivalTimeList.Add(data[3]);
                }
            }
        }

        private void InitConnections()
        {
            Connections = new List<Connection>();
            for (var i = 0; i < FromCityList.LongCount(); i++)
            {
                Connections.Add(new Connection(FromCityList.ElementAt(i), ToCityList.ElementAt(i), CreateDateFromString(DepartureTimeList.ElementAt(i)), CreateDateFromString(ArrivalTimeList.ElementAt(i))));
            }
        }

        private DateTime CreateDateFromString(string v)
        {
            var data = v.Split(':');
            DateTime dt = DateTime.Today;
            TimeSpan ts = new TimeSpan(Int32.Parse(data[0]), Int32.Parse(data[1]), 0);
            dt = dt.Date + ts;
            return dt;
        }
    }
}
