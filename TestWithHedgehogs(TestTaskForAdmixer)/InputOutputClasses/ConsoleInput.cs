using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithHedgehogs_TestTaskForAdmixer_.Interfaces;
using TestWithHedgehogs_TestTaskForAdmixer_.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestWithHedgehogs_TestTaskForAdmixer_.InputOutputClasses
{
    public class ConsoleInput : IInput
    {
        // Метод для введеня початкових даних
        public int[] InputStartData()
        {
            int[] startData = new int[Hedgehog.CcountVariantOfColorsHedgehog];

            Console.WriteLine("Pleas input information about hedgehog:");
            for (int i = 0; i < startData.Length; i++)
            {
                Console.Write($"How many hedgehog has got color {i}: ");

                startData[i] = CheckNumberRange();              
            }
            return startData;
        }

        // Метод для введення числа
        public int InputIntNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("A string cannot be converted to a number. Try again.");
            }

            return number;
        }

        // Метод для пере вірки діапазона чисел, які вводяться
        public int CheckNumberRange()
        {
            int number = InputIntNumber();

            while (number < 0 || number > int.MaxValue)
            {
                Console.WriteLine($"The range of numbers you can enter is from 0 to {int.MaxValue}. Try again.");
                number = InputIntNumber();
            }

            return number;
        }
    }
}
