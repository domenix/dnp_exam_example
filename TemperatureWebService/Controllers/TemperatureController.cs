using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TemperatureConverter;

namespace TemperatureWebService.Controllers
{
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        [EnableCors("SiteCorsPolicy")]
        [HttpPost("ctof")]
        public IActionResult CelsiusToFahrenheit([FromBody]double value)
        {
            if(!ModelState.IsValid) {
                // If value is not a valid double, return bad request
                return BadRequest();
            }

            Double temperature = TemperatureConverter.Convert.ToFahrenheit(value);
            return Ok(temperature.ToString("0.0000").Replace(",", "."));
        }

        [EnableCors("SiteCorsPolicy")]
        [HttpPost("ftoc")]
        public IActionResult FahrenheitToCelsius([FromBody]double value)
        {
            if(!ModelState.IsValid) {
                // If value is not a valid double, return bad request
                return BadRequest();
            }

            Double temperature = TemperatureConverter.Convert.ToCelsius(value);
            return Ok(temperature.ToString("0.0000").Replace(",", "."));
        }
    }
}
