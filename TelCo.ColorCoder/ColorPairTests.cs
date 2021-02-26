using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    public class ColorPairTests
    {
        ColorPairMapper colorPairMapper = new ColorPairMapper();
        ColorPairPrinter colorPairPrinter = new ColorPairPrinter();
        public void TestColorPairByNumber(int pairNumber,ColorPair expectedColorPair)
        {
            ColorPair actualColorPair = colorPairMapper.GetColorFromPairNumber(pairNumber);
            colorPairPrinter.PrintColorFromPairNumber(actualColorPair, pairNumber);
            Debug.Assert(actualColorPair.majorColor == expectedColorPair.majorColor);
            Debug.Assert(actualColorPair.minorColor == expectedColorPair.minorColor);
        }
        public void TestPairNumberByColorPair(ColorPair inputColorPair, int expectedPairNumber)
        {
            int pairNumber = colorPairMapper.GetPairNumberFromColor(inputColorPair);
            colorPairPrinter.PrintPairNumberFromColor(inputColorPair, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
