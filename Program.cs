using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int j = 2;
            int max = 100000000;
            Console.Write("Enter a number between 2-" + max.ToString() + ": ");
            string input = Console.ReadLine();
            //converts String to Int
            int numInput = Int32.Parse(input);

            //checks all of the possible numbers form the range of 2 to the max number
            for (int i = 2; i <= max; i++)
            {
                //checks if the modulo of the input number & i is 0 and that i and number input arent the same
                if (numInput % i == 0 && numInput != i)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    j++;
                    continue;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("The number is prime!");
            }
            else if (isPrime == false)
            {
                Console.WriteLine("The number isn't prime.");
                Console.WriteLine("It is divisible by " + j);
            }
            Console.ReadLine();
        }
    }
}
