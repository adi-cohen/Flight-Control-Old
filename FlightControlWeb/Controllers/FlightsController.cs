﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        private IFlightsManager manager;
        // GET: api/Flights
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Flights/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            
            return "value";
        }


        ///api/Flights/{id}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            manager.DeleteFlight(id);
        }
    }
}