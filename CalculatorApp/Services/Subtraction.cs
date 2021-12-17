using CalculatorApp.Interfaces;

namespace CalculatorApp.Services
{
    internal class Subtraction : ISubtraction
    {
        public double Subtract(double[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = i == 0 ? arr[i] : result - arr[i];
            }
            return result;
        }
    }
}
