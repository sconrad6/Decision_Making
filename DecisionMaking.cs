using System;

namespace Decision_Making
{
    class DecisionMaking
    {
        private readonly int userNumber;
        private readonly string name;

        public DecisionMaking()
        {
            userNumber = 0;
            name = "User";
        }

        public DecisionMaking(int userNumber, string name)
        {
            this.userNumber = userNumber;
            this.name = name;
        }

        // Method to determine which category the user's number falls under
        public string WhatIsTheNumber()
        {
            if ((userNumber % 2 != 0) || (userNumber % 2 != 0 && userNumber > 60))
            {
                return userNumber + " is odd.";
            }
            else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
            {
                return userNumber + " is even and less than or equal to 25.";
            }
            else if (userNumber % 2 == 0 && userNumber >= 26)
            {
                return userNumber + " is even.";
            }
            else
            {
                return "Sorry, " + name + ", but that number is invalid.";
            }
        }

        // Checks to make sure the user's number is between 1 and 100
        public static bool IsValid(int userNumber)
        {
            if (userNumber < 1 || userNumber > 100)
            {
                return false;
            }
            return true;
        }
    }
}
