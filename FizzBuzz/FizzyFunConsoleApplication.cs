namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks; 


    class FizzyFunConsoleApplication
    {
        static void Main(string[] args)
        {

            //Prints the numbers between 1 to 100 but:
            //Replaces all numbers divisible by 3 with Fizz
            //Replaces all numbers divisible by 5 with Buzz
            //Replaces all numbers divisible by both 3 and 5 with FizzBuzz
            //Ensure the user is able to see the result of the program.

            FizzyMath fizzymath = new FizzyMath();

            for (int i = 1; i <= 100; i++)
            {

                if (fizzymath.IsFizzBuzz(i))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizzymath.IsFizz(i))
                {
                    Console.WriteLine("Fizz");
                }
                else if (fizzymath.IsBuzz(i))
                {
                    Console.WriteLine("Buzz");
                }             
                else {
                    Console.WriteLine(i.ToString());
                }
                
            }
            Console.ReadLine();
        }
    }
}
