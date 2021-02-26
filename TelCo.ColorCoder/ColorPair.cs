using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        public Color[] colorMapMajor;
        public Color[] colorMapMinor;
        public int minorSize;
        public int majorSize;
        public int maxPairNumber;
        public ColorPair()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
            majorSize = colorMapMajor.Length;
            minorSize = colorMapMinor.Length;
            maxPairNumber = majorSize * minorSize;
        }
        public ColorPair(Color MajorColor,Color MinorColor)
        {
            majorColor = MajorColor;
            minorColor = MinorColor;            
        }
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
       
    }
}
