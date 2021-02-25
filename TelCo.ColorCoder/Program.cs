using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorPairHelper colorPairHelper = new ColorPairHelper();
            Console.WriteLine("Enter Option \n 1. Test Case Execution \n 2. Print Color Code Manual");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int pairNumber = 4;
                    ColorPair testPairByNumber = colorPairHelper.GetColorFromPairNumber(pairNumber);
                    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPairByNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.White);
                    Debug.Assert(testPairByNumber.minorColor == Color.Brown);
                    ColorPair testPairNumberByColorPair = new ColorPair(Color.Yellow, Color.Green);
                    pairNumber = colorPairHelper.GetPairNumberFromColor(testPairNumberByColorPair);
                    Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPairNumberByColorPair, pairNumber);
                    Debug.Assert(pairNumber == 18);
                    break;
                case 2:
                    colorPairHelper.PrintColorCodePairs();
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
        }
    }
}
