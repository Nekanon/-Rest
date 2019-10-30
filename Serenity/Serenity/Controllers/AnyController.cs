using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serenity.Interfaces;
using Serenity.Models;

namespace Serenity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnyController : ControllerBase
    {
        private readonly IAnyRepository _iar;

        public AnyController(IAnyRepository iar)
        {
            _iar = iar;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_iar.GetAll());
        }

        [HttpGet("{guid}")]
        public IActionResult Get(Guid guid)
        {
            return Ok(_iar.Get(guid));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Any any)
        {
            return Ok(_iar.Create(any));
        }

        [HttpPut("{guid}")]
        public IActionResult Update([FromBody] Any any, [FromRoute] Guid guid)
        {
            return Ok(_iar.Update(guid, any));
        }

        [HttpDelete("{guid}")]
        public IActionResult Delete([FromRoute] Guid guid)
        {
            return Ok(_iar.Delete(guid));
        }
    }

    
}