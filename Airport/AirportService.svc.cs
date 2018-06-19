﻿using System;
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

        public string GetConnectionBetween(string airportA, string airportB)
        {
            List<Connection> connections = new List<Connection>();
            List<Connection> indirectConnections = new List<Connection>();
            foreach (var connection in airportBase.Connections)
            {
                if (connection.From.ToLower().Equals(airportA.ToLower()) && connection.To.ToLower().Equals(airportB.ToLower())) {
                    connections.Add(connection);
                }
                foreach (var _connection in airportBase.Connections)
                {
                    if (!_connection.From.ToLower().Equals(airportA) && !_connection.From.ToLower().Equals(airportB) && _connection.To.ToLower().Equals(airportB))
                    {
                        if(connection.To.Equals(_connection.From))
                        {
                            indirectConnections.Add(_connection);
                        }
                    }
                }
            }
            
            return ListAsStringsOfConnections(connections) + Environment.NewLine + Environment.NewLine + ListAsStringsOfConnections(indirectConnections);
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
