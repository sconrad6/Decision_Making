using System;
namespace Decision_Making
{
    public class DecisionMakingTest
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();

            string userChoice = "y";
            do
            {   // Promt the user to enter a number
                Console.WriteLine("\n" + name + ", Please enter a whole number between 1 and 100");
                int number = int.Parse(Console.ReadLine());
                DecisionMaking decision1 = new DecisionMaking(number, name);

                // Check to see if the number the user entered is valid - if it is invalid the program promts the user to try again 
                if (!DecisionMaking.IsValid(number))
                {
                    Console.WriteLine("Invalid number. Please try again.");
                    continue;
                }

                // Prints out the number and what that number is utilizing the WhatIsTheNumber() method
                Console.WriteLine("\nGreat number, " + name + "!");
                Console.WriteLine(decision1.WhatIsTheNumber());

                // Asks the user if they would like to enter another number - if they do, it will continue, if they don', the program will end
                Console.Write("\nWould you like to enter another number, " + name + "? Please press Y for yes and N for no. ");
                userChoice = Console.ReadLine().ToLower();

            } while (userChoice == "y");
            Console.WriteLine("\nThank you for playing, " + name + "! Have a nice day.");
        }
    }
}
