using System;
namespace Decision_Making
{
    public class DecisionMakingTest
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();

            char userChoice;
            do
            {
                Console.WriteLine("\n" + name + ", Please enter a whole number between 1 and 100");
                int number = int.Parse(Console.ReadLine());
                DecisionMaking decision1 = new DecisionMaking(number, name);

                if (!DecisionMaking.IsValid(number))
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
              
                Console.WriteLine("\nGreat number, " + name + "!");

                Console.WriteLine(decision1);

                Console.Write("\nWould you like to enter another number, " + name + "? Please press Y for yes and N for no. ");
                userChoice = Console.ReadKey().KeyChar;

            } while (userChoice == 'Y' || userChoice == 'y');
            Console.WriteLine("\nThank you for playing, " + name + "! Have a nice day.");
        }
    }
}
