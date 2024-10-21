using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public enum Operator
        {
            Add, Sub, Mul, Div
        }

        public IActionResult Result(Operator? op, double? a, double? b)
        {
            if (a is null || b is null)
            {
                ViewBag.ErrorMessage = "Niepoprawny format liczby w parametrze a lub b";
                return View("CustomError");
            }
            ViewBag.a = a;
            ViewBag.b = b;

            if (op is null)
            {
                ViewBag.ErrorMessage = "Niepoprawny operator";
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
                case Operator.Mul:
                    ViewBag.result = a * b;
                    ViewBag.op = "*";
                    break;
                case Operator.Div:
                    ViewBag.result = a / b;
                    ViewBag.op = ":";
                    break;
            }
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}