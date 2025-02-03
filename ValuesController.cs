using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> _values = new() { "value1", "value2" };

        [HttpGet]
        public IActionResult Get() => Ok(_values);

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return BadRequest("Value cannot be empty.");

            _values.Add(value);
            return Ok(_values);
        }
    }
}
