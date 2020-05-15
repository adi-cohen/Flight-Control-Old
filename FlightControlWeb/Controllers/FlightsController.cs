using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FlightControlWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase 
    {
        private IFlightsManager manager = new FlightsManager();
        // GET: api/Flights?relative_to=<DATE_TIME>
        [HttpGet]
        public IEnumerable<Flight> Get(DateTime relativeTo)
        {
            List<Flight> flightsWithRelaticTime = manager.GetAllFlights().Where(x=> x.Date)
            return manager.GetAllFlights();
        }

        // GET: api/Flights/5
        [HttpGet("{id}", Name = "GetFlight")]
        public string Get(int id)
        {
            
            return "value";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        //[Route("/api/Flights/{id}")]
        public void Delete(int id)
        {
            manager.DeleteFlight(id);
        }
    }
}
