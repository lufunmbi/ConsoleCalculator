using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                InputConverter inputconverter = new InputConverter();
                CalculatorEngine calculatorengine = new CalculatorEngine();

                double firstNumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                double secondNumber = inputconverter.ConvertToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorengine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
