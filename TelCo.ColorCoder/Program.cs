using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorPairMapper colorPairMapper = new ColorPairMapper();
            ColorPair colorPair = new ColorPair();
            Console.WriteLine("Enter Option \n 1. Test Case Execution \n 2. Print Color Code Manual");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int pairNumber = 4;
                    ColorPair testPairByNumber = colorPairMapper.GetColorFromPairNumber(pairNumber);
                    colorPair.DisplayColorFromPairNumber(testPairByNumber, pairNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.White);
                    Debug.Assert(testPairByNumber.minorColor == Color.Brown);
                    pairNumber = 5;
                    testPairByNumber = colorPairMapper.GetColorFromPairNumber(pairNumber);
                    colorPair.DisplayColorFromPairNumber(testPairByNumber, pairNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.White);
                    Debug.Assert(testPairByNumber.minorColor == Color.SlateGray);
                    pairNumber = 23;
                    testPairByNumber = colorPairMapper.GetColorFromPairNumber(pairNumber);
                    colorPair.DisplayColorFromPairNumber(testPairByNumber, pairNumber);
                    Debug.Assert(testPairByNumber.majorColor == Color.Violet);
                    Debug.Assert(testPairByNumber.minorColor == Color.Green);

                    ColorPair testPairNumberByColorPair = new ColorPair(Color.Yellow, Color.Green);
                    pairNumber = colorPairMapper.GetPairNumberFromColor(testPairNumberByColorPair);
                    colorPair.DisplayPairNumberFromColor(testPairNumberByColorPair, pairNumber);
                    Debug.Assert(pairNumber == 18);
                    testPairNumberByColorPair = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
                    pairNumber = colorPairMapper.GetPairNumberFromColor(testPairNumberByColorPair);
                    colorPair.DisplayPairNumberFromColor(testPairNumberByColorPair, pairNumber);
                    Debug.Assert(pairNumber == 6);
                    break;

                case 2:
                    colorPairMapper.PrintColorCodePairs();
                    break;               
            }
        }
    }
}
