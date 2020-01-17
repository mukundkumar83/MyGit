using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOnNet.ArraysSample
{
    public class TwoDimension
    {

        public void TestTwoDimension()
        {
            // Many better way to impliment the below sample but i am doing it in more explaining way.

            //******************************Two Dimension Array
            Console.WriteLine("Two Dimension Example");
            int[,] numArray;   // blank array declared

            numArray = new int[2, 10]; // Array Initialization with size of 10 of interger data type 

            // Lopping through to assign 1 to 10 value in array.
            for (int i = 0; i < 10; i++)
            {
                numArray[0, i] = i + 1;
            }
            // Lopping through to assign 1 to 10 value in array.
            for (int i = 0; i < 10; i++)
            {
                numArray[1, i] = i + 1;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("[0," + i + "]=" + numArray[0, i]); //To access the assigne value from array based on index
            }
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("[1,"+i+"]=" + numArray[1, i]); //To access the assigne value from array based on index
            }
            Console.WriteLine("");
            Console.WriteLine("Thanks for your time");
     
            //*********************End
            /*
            * Output of this program will be 
            * The Number is10
               1
               2
               3
               4
               5
               6
               7
               8
               9
               10
               Thanks for your time
            */
            // 
        }

    }
}
