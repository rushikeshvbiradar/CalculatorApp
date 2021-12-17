using CalculatorApp.Interfaces;
using CalculatorApp.Services;

namespace CalculatorApp.View
{
    internal class Calculator
    {
        private int choice;
        private int limit;
        private double[] input;
        private double result;

        // start calculator
        public void StartCalculator() {
            int showMenu = 0;
            do
            {
                choice = SelectOperation();
                if (choice != 5)
                {
                    limit = FetchNumberLimit();
                    input = FetchNumbers();
                    CalculateResult();
                    DisplayResult();

                    Console.Write("\n Press 0 to exit or 1 to continue : ");
                    showMenu = ReadInput();
                }
            } while (showMenu == 1);
        }

        // select arithmatic operation
        private int SelectOperation() {
            Console.WriteLine("Please select your choice...");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            
            int selection = ReadInput();

            if (selection > 0 && selection < 6)
                return selection;
            else {
                Console.WriteLine("Invalid choice.");
                return SelectOperation();
            }
        }

        private int FetchNumberLimit() {
            Console.WriteLine("\nHow many numbers you want for this operation?");
            return ReadInput();
        }

        private double[] FetchNumbers() {
            double[] arr = new double[limit];
            Console.WriteLine("Enter " + limit + " numbers to continue");
            for (int i = 0; i < limit; i++)
            {
                double num = ReadInput();
                arr[i] = num;
            }

            return arr;
        }

        private void CalculateResult() {
            try
            {
                result = 0;
                switch (choice) {
                    case 1:
                        IAddition operationAddition = new Addition();
                        result = operationAddition.Add(input);
                        break;
                    case 2:
                        ISubtraction operationSubtraction = new Subtraction();
                        result = operationSubtraction.Subtract(input);
                        break;
                    case 3:
                        IMultiplication operationMultiplication = new Multiplication();
                        result = operationMultiplication.Multiply(input);
                        break;
                    case 4:
                        IDivision operationDivision = new Division();
                        result = operationDivision.Divide(input);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured... \n" + ex.Message);
            }
        }

        private int ReadInput() {
            int n = 0;
            bool isChoiceValid = false;
            try
            {
                n = int.Parse(Console.ReadLine());
                isChoiceValid = true;
            }
            catch (Exception) {
                Console.WriteLine("\nPlease select numeric choice only");
            }

            return isChoiceValid ? n : ReadInput();
        }

        private void DisplayResult() {
            string inputStr = string.Join(",", input);
            Console.WriteLine("\nYour input : " + inputStr);
            Console.WriteLine("\nResult : " + result);
        }
    }
}
