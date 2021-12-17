using CalculatorApp.Interfaces;

namespace CalculatorApp.Services
{
    internal class Addition : IAddition
    {
        public double Add(double[] arr)
        {
            return arr.Sum();
        }

    }
}
