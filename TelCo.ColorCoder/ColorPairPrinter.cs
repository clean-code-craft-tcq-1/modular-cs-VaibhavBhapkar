using System;

namespace TelCo.ColorCoder
{
    public class ColorPairPrinter
    {
        ColorPairMapper colorPairMapper = new ColorPairMapper();
        public void PrintColorCodePairReferenceManual()
        {
            Console.WriteLine("Please find color code manual below, \n");
            for (int i = 1; i <= 25; i++)
            {
                ColorPair colorPairByNumber = colorPairMapper.GetColorFromPairNumber(i);
                Console.WriteLine("Pair Number: {0},Colors: {1}\n", i, colorPairByNumber);
            }
        }
        public void PrintColorFromPairNumber(ColorPair colorPair, int pairNumber)
        {
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
        }
        public void PrintPairNumberFromColor(ColorPair colorPair, int pairNumber)
        {
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", colorPair, pairNumber);
        }
    }
}
