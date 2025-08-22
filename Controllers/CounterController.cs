//Counter
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ICounterService _counterService;

       
        public CounterController(ICounterService counterService)
        {
            _counterService = counterService;
        }

        [HttpGet("increment")]
        public IActionResult Increment()
        {
            int val = _counterService.Increment() + 5;
            return Ok(new { Value = val});
        }

        [HttpGet("decrement")]
        public IActionResult Decrement()
        {
            return Ok(new { Value = _counterService.Decrement() });
        }

        [HttpGet("current")]
        public IActionResult GetCurrent()
        {
            return Ok(new { Value = _counterService.GetValue() });
        }

        [HttpGet]
        public int getById(int id)
        {
            return id;
        }
    }
}
