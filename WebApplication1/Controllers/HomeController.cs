using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Calculator(string op, double? a, double? b)
    {
        if (a is null || b is null)
        {
            ViewBag.ErrorMessage = "Niepoprawny format w parametrze a lub b";
            return View("CustomError");
        }
        ViewBag.a = a;
        ViewBag.b = b;

        if (op != "add" || op != "sub" || op != "nul" || op != "div")
        {
            ViewBag.ErrorMessage = "Niepoprawny operator!";
            return View("CustomError");
        }
        
        switch (op)
        {
            case Operator.Add:
                ViewBag.result = a + b;
                ViewBag.op = "+";
                break;
            case Operator.Sub:
                ViewBag.result = a - b;
                ViewBag.op = "-";
                break;
            case Operator.Div:
                ViewBag.result = a * b;
                ViewBag.op = "*";
                break;
            case Operator.Mul:
                ViewBag.result = a / b;
                ViewBag.op = "/";
                break;
        }
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    public enum Operator
    {
        Add, Sub, Mul, Div
    }
}