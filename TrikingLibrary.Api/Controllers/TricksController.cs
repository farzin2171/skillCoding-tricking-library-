using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TrikingLibrary.Api.Models;

namespace TrikingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/tricks")]
    public class TricksController:ControllerBase
    {
        private readonly TrickStore _store;
        public TricksController(TrickStore store)
        {
            _store = store;
        }
        [HttpGet]
        public IActionResult All() => Ok(_store.All);
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_store.All.FirstOrDefault(x => x.Id.Equals(id)));

        [HttpPost]
        public IActionResult Create([FromBody] Trick trick)
        {
            _store.Add(trick);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] Trick trick)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
