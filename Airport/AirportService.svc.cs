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
            return ListAsStringsOfConnections(airportBase.Connections);
        }

        public string GetConnectionBetween(string airportA, string airportB, DateTime from)
        {
            List<Connection> connections = new List<Connection>();
            List<Connection> indirectConnections = new List<Connection>();
            foreach (var connection in airportBase.Connections)
            {
                if (DateTime.Compare(from, connection.Departure) <= 0)
                {
                    if (connection.From.ToLower().Equals(airportA) && connection.To.ToLower().Equals(airportB))
                    {
                        connections.Add(connection);
                    } else 
                    if (connection.To.ToLower().Equals(airportB))
                    {
                        indirectConnections.Add(connection);
                    }
                }
                
            }
            
            return ListAsStringsOfConnections(connections) + Environment.NewLine + "Indirect connections" + Environment.NewLine  + ListAsStringsOfConnections(indirectConnections);
        }

        private string ListAsStringsOfConnections(List<Connection> connections)
        {
            string connectionsToReturn = "";
            foreach (var connection in connections)
            {
                connectionsToReturn += connection.ToString() + Environment.NewLine;
            }
            return connectionsToReturn;
        }
    }
}
