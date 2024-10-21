using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Calculator")]
    public class CalculatorController : Controller
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("Result")]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error", model);
            }
            return View(model);
        }
    }
}