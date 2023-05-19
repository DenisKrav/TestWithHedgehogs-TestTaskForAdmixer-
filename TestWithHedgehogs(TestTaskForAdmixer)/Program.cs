using TestWithHedgehogs_TestTaskForAdmixer_.InputOutputClasses;

namespace TestWithHedgehogs_TestTaskForAdmixer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleInput consoleInput = new ConsoleInput();

            int[] startData = consoleInput.InputStartData();
            Console.WriteLine();
        }
    }
}