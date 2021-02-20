using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorCoderPairs
    {   
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {           
            if (pairNumber < 1 || pairNumber > ColorDetails.maxPairNumber)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / ColorDetails.minorSize;
            int minorIndex = zeroBasedPairNumber % ColorDetails.minorSize;
            ColorPair pair = new ColorPair(ColorDetails.colorMapMajor[majorIndex], ColorDetails.colorMapMinor[minorIndex]);                                 
            return pair;
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = ColorDetails.FindMajorNumberFromColor(pair);
            int minorIndex = ColorDetails.FindMinorNumberFromColor(pair);
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorDetails.minorSize) + (minorIndex + 1);
        } 
        public static void PrintColorCodePairs()
        {
            Console.WriteLine("Please find color code manual below, \n");
            for (int i=1;i<=25;i++)
            {
                ColorPair colorPairByNumber= GetColorFromPairNumber(i);
                Console.WriteLine("Pair Number: {0},Colors: {1}\n", i, colorPairByNumber);
            }
        }
    }
}
