using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColorDetails
    {
        public static Color[] colorMapMajor;
        public static Color[] colorMapMinor;
        public static int minorSize;
        public static int majorSize;
        public static int maxPairNumber;
        static ColorDetails()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
            majorSize = colorMapMajor.Length;
            minorSize = colorMapMinor.Length;
            maxPairNumber = majorSize * minorSize;
        }
        public static int FindMajorNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorDetails.majorSize; i++)
            {
                if (ColorDetails.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;
        }
        public static int FindMinorNumberFromColor(ColorPair pair)
        {
            int minorIndex = -1;
            for (int i = 0; i < ColorDetails.minorSize; i++)
            {
                if (ColorDetails.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }
    }
}
