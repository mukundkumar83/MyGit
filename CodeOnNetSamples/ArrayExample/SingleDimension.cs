using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOnNet.ArraysSample
{
    public class SingleDimension
    {

        public void SingleDimensionTest()
        {
            int numTen = 10;

            Console.WriteLine("The Number is" + numTen);  // Printing the number on console
                                                          //******************************Single Dimension Array
            int[] numArray;   // blank array declared

            numArray = new int[10]; // Array Initialization with size of 10 of interger data type 

            // Lopping through to assign 1 to 10 value in array.
            for (int i = 0; i < 10; i++)
            {
                numArray[i] = i + 1;
            }

            Console.WriteLine("Single Dimension Example");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("["+i+"]="+numArray[i]); //To access the assigne value from array based on index
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
