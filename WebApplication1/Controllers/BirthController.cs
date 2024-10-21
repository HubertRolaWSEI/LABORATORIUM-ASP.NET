using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BirthController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Birth model)
        {
            if (!model.IsValid())
            {
                return View("Error", model);
            }
            return View(model);
        }
    }
}