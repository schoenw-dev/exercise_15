using System;

namespace exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);



                for (int i = 1; i <= userNumber; i++)
                {

                    Console.WriteLine(i * i * i);

                }

                Console.WriteLine("Would you like to continue? (y|n)");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "y")
                {
                    repeat = true;
                }
                else if (userAnswer == "n")
                {
                    repeat = false;
                }


            }

            Console.WriteLine("Goodbye!");

        }
    }
}
