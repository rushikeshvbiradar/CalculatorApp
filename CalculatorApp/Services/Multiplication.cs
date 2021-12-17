using CalculatorApp.Interfaces;

namespace CalculatorApp.Services
{
    internal class Multiplication : IMultiplication
    {
        public double Multiply(double[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = i == 0 ? arr[i] : result * arr[i];
            }
            return result;
        }
    }
}
