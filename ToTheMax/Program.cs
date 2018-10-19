using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Array generator! Let's build an array of numbers.");

            //create an array that will hold (n) numbers
            //ask and validate users numbers to fill array
            int arraySize = GetNumbers("How big should the array be?");

            int[] userArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                userArray[i] = GetNumbers("What number would you like to add to your array?");
            }

            int maxNumber = userArray[0];

            //Find maximum number in an array
            //use foreach loop
            foreach (int number in userArray)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            //print max number to console
            Console.WriteLine($"The largest number in your array is {maxNumber}");
            Console.ReadLine();

            //OR you could just use userArray.Max() to get the maximum number in the array
            //but the instructions said to use a foreach loop so I did >.<
        }

        static int GetNumbers(string message)
        {
            int number;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine($"Sorry that's invalid please try again! {message}");
            }
            return number;
        }
    }
}
