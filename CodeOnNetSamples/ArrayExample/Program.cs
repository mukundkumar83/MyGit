using System;
using CodeOnNet.ArraysSample;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple initialization
            SingleDimension singleDimension = new SingleDimension();
            TwoDimension twoDimension = new TwoDimension();

            singleDimension.SingleDimensionTest();
            twoDimension.TestTwoDimension();

            Console.ReadKey();

            // OutPut

            //            The Number is10
            //Single Dimension Example
            //[0] = 1[1] = 2[2] = 3[3] = 4[4] = 5[5] = 6[6] = 7[7] = 8[8] = 9[9] = 10
            //Thanks for your time
            //Two Dimension Example
            //[0, 0] = 1[0, 1] = 2[0, 2] = 3[0, 3] = 4[0, 4] = 5[0, 5] = 6[0, 6] = 7[0, 7] = 8[0, 8] = 9[0, 9] = 10
            //[1, 0] = 1[1, 1] = 2[1, 2] = 3[1, 3] = 4[1, 4] = 5[1, 5] = 6[1, 6] = 7[1, 7] = 8[1, 8] = 9[1, 9] = 10
            //Thanks for your time
        }
    }
}
