using System.Net;
using TestWithHedgehogs_TestTaskForAdmixer_.Algorithms;
using TestWithHedgehogs_TestTaskForAdmixer_.Services.API;
using TestWithHedgehogs_TestTaskForAdmixer_.Services.Input;
using TestWithHedgehogs_TestTaskForAdmixer_.Services.Output;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestWithHedgehogs_TestTaskForAdmixer_
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ConsoleInput consoleInput = new ConsoleInput();
            ConsoleOutput consoleOutput = new ConsoleOutput();
            AlgorithmsForHedgehogs alorithm = new AlgorithmsForHedgehogs();
            HedgehogsOperAPIService operationAPI = new HedgehogsOperAPIService("https://localhost:7299");

            int[] startData = consoleInput.InputStartData();
            int minNumberSteps = alorithm.CountMinNumberSteps(startData);

            consoleOutput.PrintNumber(minNumberSteps, "Minimum number of steps");

            try
            {
                Dictionary<int, string> numberColorHedgehogs = await operationAPI.GetNumberHedgehogsTheirColor(startData);

                consoleOutput.PrintColorNumberHedgehogs(numberColorHedgehogs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}