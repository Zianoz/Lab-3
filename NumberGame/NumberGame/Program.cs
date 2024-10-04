using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace NumbersGameReworked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A default bool value for the game
            bool token = true;

            //While token = true, the game will run on repeat
            while (token)
            {

                //Saves the user number in "userNumber". "tries" saves the amount of tries in itself.
                Console.WriteLine("Welcome to the numbersgame!");
                Console.WriteLine("You have 5 tries to guess the number");

                Console.WriteLine("Please choose the highest number it can be 1 - ?");

                //Lets the user decide what the highest number can be and inserts it into the RandomNumberGenerator method
                int gameNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Guess a number between 1 - {gameNumber}");

                int userNumber = Convert.ToInt32(Console.ReadLine());
                int tries = 4;

                //A method for generating a random number, inserts gameNumber to the method.
                int number = RandomNumberGenerator(gameNumber);

                NumberCheck(userNumber, number, tries);

                //This while loop lets the user guess the randomly generated number until either tries run out or when the user guesses the correct number.
                while (tries > 0 && userNumber != number)
                {
                    tries--;
                    Console.WriteLine("Try again.");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    //Calls the method NumberCheck and passes the values of the arguments to the method.
                    NumberCheck(userNumber, number, tries);

                }

                //This if checks if the number is equal to the generated random number
                if (userNumber == number)
                {
                    Console.WriteLine("You guessed correctly!");
                }

                //This else tells the user if they ran out of tries
                else
                {
                    Console.WriteLine("You've ran out of tries!");
                }

                //This calls the method "PlayAgain();" and it lets the user decide if they want to play again or not.
                token = PlayAgain();

            }

            //This is the method that generates a random number between 1 and 20. It then returns number
            static int RandomNumberGenerator(int gameNumber)
            {
                Random random = new Random();
                int number = random.Next(1, gameNumber + 1);
                return number;

            }

            //This is a method that lets the user play again. 
            static bool PlayAgain()
            {
                Console.WriteLine("Would you like to play again? Y/N");
                string choice = Console.ReadLine().ToUpper();

                //If the user wants to play again it returns true to token which starts the game again.
                if (choice == "Y")
                {
                    return true;
                }

                //if the user decides not to play again it returns false to token which ends the while loop for the game.
                else if (choice == "N")
                {
                    return false;
                }

                //if the user enters anything other than Y or N it returns the PlayAgain method and lets the user enter the correct input again.
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N");
                    return PlayAgain();
                }
            }

            //This method compares userNumber and Number and prints out the results to the user.
            //If userNumber is bigger than number print out too high, if userNumber is smaller than number print out too low
            static void NumberCheck(int userNumber, int number, int tries)
            {
                if (userNumber > number)
                {
                    Console.Write("Your guess was abit too high! ");
                    Console.Write($"You have {tries} tries left. ");
                }

                else if (userNumber < number)
                {
                    Console.Write("Your guess was abit too low! ");
                    Console.Write($"You have {tries} tries left. ");
                }

            }

        }

    }
}
