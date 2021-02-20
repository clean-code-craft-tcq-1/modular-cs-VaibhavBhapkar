using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Option \n 1. Test Case Execution \n 2. Print Color Code Manual");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    int pairNumber = 4;
                    ColorPair testPairByNumber = ColorCoderPairs.GetColorFromPairNumber(pairNumber);
                    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPairByNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.White);
                    Debug.Assert(testPairByNumber.minorColor == Color.Brown);
                    pairNumber = 5;
                    testPairByNumber = ColorCoderPairs.GetColorFromPairNumber(pairNumber);
                    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPairByNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.White);
                    Debug.Assert(testPairByNumber.minorColor == Color.SlateGray);
                    pairNumber = 23;
                    testPairByNumber = ColorCoderPairs.GetColorFromPairNumber(pairNumber);
                    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPairByNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.Violet);
                    Debug.Assert(testPairByNumber.minorColor == Color.Green);
                    ColorPair testPairNumberByColorPair = new ColorPair(Color.Yellow, Color.Green);
                    pairNumber = ColorCoderPairs.GetPairNumberFromColor(testPairNumberByColorPair);
                    Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPairNumberByColorPair, pairNumber);
                    Debug.Assert(pairNumber == 18);
                    testPairNumberByColorPair = new ColorPair(Color.Red, Color.Blue);
                    pairNumber = ColorCoderPairs.GetPairNumberFromColor(testPairNumberByColorPair);
                    Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPairNumberByColorPair, pairNumber);
                    Debug.Assert(pairNumber == 6);
                    break;
                case 2:
                    ColorCoderPairs.PrintColorCodePairs();
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
        }
    }
}
