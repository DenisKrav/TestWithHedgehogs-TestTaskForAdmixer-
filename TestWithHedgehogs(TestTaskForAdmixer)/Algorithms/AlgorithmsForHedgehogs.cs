using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestWithHedgehogs_TestTaskForAdmixer_.Algorithms
{
    public class AlgorithmsForHedgehogs
    {
        public int CountMinNumberSteps(int[] startData)
        {
            List<int> indexes;

            if (CheckGroup(startData, out indexes))
            {
                int difference = Math.Abs(startData[indexes[0]] - startData[indexes[1]]) / 3;
                return difference + Math.Min(startData[indexes[0]], startData[indexes[1]]) + difference * 2;
            }
            else
            {
                return -1;
            }
        }

        public bool CheckGroup(int[] startData, out List<int> indexes)
        {
            indexes = new List<int>();

            for (int i = 0; i < startData.Length; i++)
            {
                for (int j = i + 1; j < startData.Length; j++)
                {
                    if (startData[i] == startData[j] || (startData[i] - startData[j]) % 3 == 0)
                    {
                        indexes.Add(i);
                        indexes.Add(j);
                        return true;
                    }                  
                }
            }

            return false;
        }
    }
}
