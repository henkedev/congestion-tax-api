using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CongestiontaxApi.Models;

namespace CongestiontaxApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CongestionTaxController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VehicleEntry> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new VehicleEntry
            {                
                Fee = 100
            })
            .ToArray();
        }
    }
}
