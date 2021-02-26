using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorPairPrinter colorPairPrinter = new ColorPairPrinter();
            ColorPairTests colorPairTests = new ColorPairTests();
            Console.WriteLine("Enter Option \n 1. Test Case Execution \n 2. Print Color Code Manual");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    colorPairTests.TestColorPairByNumber(4, new ColorPair(Color.White, Color.Brown));
                    colorPairTests.TestColorPairByNumber(5, new ColorPair(Color.White, Color.SlateGray));
                    colorPairTests.TestColorPairByNumber(23, new ColorPair(Color.Violet, Color.Green));

                    colorPairTests.TestPairNumberByColorPair(new ColorPair(Color.Yellow, Color.Green), 18);
                    colorPairTests.TestPairNumberByColorPair(new ColorPair(Color.Red, Color.Blue), 6);                   
                    break;

                case 2:
                    colorPairPrinter.PrintColorCodePairReferenceManual();
                    break;                

                default:
                    Console.WriteLine("Please Enter a Valid Input");
                    break;
            }
        }
    }
}
