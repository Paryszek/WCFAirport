using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Airport
{
    public class AirportService : IAirportService
    {
        AirportBase airportBase;
        public AirportService()
        {
            airportBase = new AirportBase();
        }

        public string GetEveryConnection()
        {
            string connectionsToReturn = "";
            foreach(var connection in airportBase.Connections)
            {
                connectionsToReturn += connection.ToString() + Environment.NewLine;
            }
            return connectionsToReturn;
        }
    }
}
