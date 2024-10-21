using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class Calculator
    {
        public enum Operators
        {
            Add, Sub, Mul, Div
        }

        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public string Op
        {
            get
            {
                return Operator switch
                {
                    Operators.Add => "+",
                    Operators.Sub => "-",
                    Operators.Mul => "*",
                    Operators.Div => "/",
                    _ => ""
                };
            }
        }

        public string ErrorMessage;

        public bool IsValid()
        {
            if (X is null)
            {
                ErrorMessage = "Podaj parametr X";
                return false;
            }

            if (Y is null)
            {
                ErrorMessage = "Podaj parametr Y";
                return false;
            }

            if (Operator is null)
            {
                ErrorMessage = "Podaj operator";
                return false;
            }


            return true;
        }

        public double Calculate()
        {
            return Operator switch
            {
                Operators.Add => (double)(X + Y),
                Operators.Sub => (double)(X - Y),
                Operators.Mul => (double)(X * Y),
                Operators.Div => (double)(X / Y),
                _ => double.NaN
            };
        }
    }
}