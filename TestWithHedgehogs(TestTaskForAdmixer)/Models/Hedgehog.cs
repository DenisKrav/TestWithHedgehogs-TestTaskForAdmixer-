using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithHedgehogs_TestTaskForAdmixer_.Models
{
    public class Hedgehog
    {
        private int color;
        private static int countVariantOfColorsHedgehog = 3;

        public int Color 
        {
            get { return color; }
        }
        public static int CcountVariantOfColorsHedgehog
        {
            get { return countVariantOfColorsHedgehog; }
        }

        public void ChangeColor(int newColor)
        {
            color = newColor;
        }

        public static void ChangeCountVariantOfColorsHedgehog(int newCount)
        {
            countVariantOfColorsHedgehog = newCount;
        }
    }
}
