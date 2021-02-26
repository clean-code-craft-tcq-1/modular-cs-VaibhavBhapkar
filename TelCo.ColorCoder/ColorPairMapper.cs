using System;

namespace TelCo.ColorCoder
{
    class ColorPairMapper
    {
        ColorPair colorPair = new ColorPair();        
        public ColorPair GetColorFromPairNumber(int pairNumber)
        {           
            if (pairNumber < 1 || pairNumber > colorPair.maxPairNumber)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / colorPair.minorSize;
            int minorIndex = zeroBasedPairNumber % colorPair.minorSize;
            ColorPair pair = new ColorPair(colorPair.colorMapMajor[majorIndex], colorPair.colorMapMinor[minorIndex]);                                 
            return pair;
        }
        public int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.FindIndex(colorPair.colorMapMajor, item => item == pair.majorColor);
            int minorIndex = Array.FindIndex(colorPair.colorMapMinor, item => item == pair.minorColor);
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            // Compute pair number and Return(Note: +1 in compute is because pair number is 1 based, not zero)  
            return (majorIndex * colorPair.minorSize) + (minorIndex + 1);
        } 
        
    }
}
