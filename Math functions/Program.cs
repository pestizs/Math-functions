using System;

namespace Math_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two numbers which we are going to combine.
            float numberOne = 15f;
            float numberTwo = 5f;
            float result = 0;
            //A string for user input and for output
            string userInput;
            string selectedFunction = "";
            //Try to give clear instructions to user
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("Please type one of +,-,* or /");
            Console.WriteLine("Then press Enter");
            userInput = Console.ReadLine();

            //Depending on the user input; we want to perform a specific operation
            switch (userInput)
            {
                case "+":
                    selectedFunction = "addition";
                    result = numberOne + numberTwo;
                    //Break tells the computer to move to the end of the block
                    break;
                case "-":
                    selectedFunction = "substraction";
                    result = numberOne - numberTwo;
                    break;
                case "*":
                    selectedFunction = "multiplication";
                    result = numberOne * numberTwo;
                    break;
                case "/":
                    selectedFunction = "division";
                    result = numberOne / numberTwo;
                    break;
                default:
                    selectedFunction = "invalid input";
                    break;
            }
            if (selectedFunction == "invalid input")
            {
                Console.WriteLine("Your input is invalid.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You selected {0}, with the result of {1}", selectedFunction, result);
                Console.ReadLine();
            }

        }
    }
}
