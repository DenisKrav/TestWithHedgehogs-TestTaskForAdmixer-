using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithHedgehogs_TestTaskForAdmixer_.Interfaces;

namespace TestWithHedgehogs_TestTaskForAdmixer_.InputOutputClasses.Output
{
    internal class ConsoleOutput : IOutput
    {
        public void PrintNumber(int number, string massege)
        {
            Console.WriteLine(massege + ": " + number); 
        }
    }
}
