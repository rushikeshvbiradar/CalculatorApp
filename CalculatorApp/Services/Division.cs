using CalculatorApp.Interfaces;

namespace CalculatorApp.Services
{
    internal class Division : IDivision
    {
        public double Divide(double[] arr)
        {
            double result = 0;
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    result = i == 0 ? arr[i] : result / arr[i];
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please check your inputs.\n");
            }
            return result;
        }
    }
}
