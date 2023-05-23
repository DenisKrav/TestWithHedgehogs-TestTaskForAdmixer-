using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithHedgehogs_TestTaskForAdmixer_.Interfaces;

namespace TestWithHedgehogs_TestTaskForAdmixer_.Services.Output
{
    internal class ConsoleOutput : IOutput
    {
        public void PrintNumber(int number, string massege)
        {
            Console.WriteLine(massege + ": " + number); 
        }

        public void PrintColorNumberHedgehogs(Dictionary<int, string> numberColorHedgehogs)
        {
            Console.WriteLine("\nHow many hedgehogs of which colors: ");
            foreach (var kvp in numberColorHedgehogs)
            {
                Console.WriteLine($"Hedgehog {kvp.Key}: {kvp.Value}");
            }
        }
    }
}
