using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class FlightsManager : IFlightsManager
    {

        private static List<Flight> flights = new List<Flight>();

        public void DeleteFlight(int id)
        {
            //if empty
            if (!flights.Any())
            {
                Console.Out.WriteLine("flights list is empty");
            }
            else
            {
                Flight f = flights.Where(x => x.FlightId == id).FirstOrDefault();
                if (f == null)
                {
                    throw new Exception("flight not found");
                }
                flights.Remove(f);
            }
            
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return flights;
        }

        public IEnumerable<Flight> GetInternalFlights()
        {
            List<Flight> internalFlights = flights.Where(x => x.IsExternal == false).ToList();
            return internalFlights;
        }
    }
}
