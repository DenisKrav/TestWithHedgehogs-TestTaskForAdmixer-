using TestWithHedgehogs_TestTaskForAdmixer_.Algorithms;
using TestWithHedgehogs_TestTaskForAdmixer_.InputOutputClasses.Input;
using TestWithHedgehogs_TestTaskForAdmixer_.InputOutputClasses.Output;

namespace TestWithHedgehogs_TestTaskForAdmixer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleInput consoleInput = new ConsoleInput();
            ConsoleOutput consoleOutput = new ConsoleOutput();
            AlgorithmsForHedgehogs alorithm = new AlgorithmsForHedgehogs();

            int[] startData = consoleInput.InputStartData();
            int minNumberSteps = alorithm.CountMinNumberSteps(startData);

            consoleOutput.PrintNumber(minNumberSteps, "Minimum number of steps");
        }
    }
}