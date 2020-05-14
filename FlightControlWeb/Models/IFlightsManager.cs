using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public interface IFlightsManager
    {
        IEnumerable<Flight> GetInternalFlights();

        //get internal and external flights
        IEnumerable<Flight> GetAllFlights();
        void DeleteFlight(int id);
    }
}
