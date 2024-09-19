using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumbersGame
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string Playagain()
            {
                Console.WriteLine("Vill du spela igen? JA/NEJ");
                String userAnswer = Console.ReadLine();
                userAnswer = userAnswer.ToUpper();
                return userAnswer;
            }

            bool game = true;

            while (game == true)
            {
                int tries = 5;
                Random random = new Random();
                int generatedNumber = random.Next(1, 21);

                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");
                int playerGuess = Convert.ToInt32(Console.ReadLine());
                tries--;
                Console.WriteLine($"Du har nu {tries} försök kvar");

                {
                    while (playerGuess != generatedNumber && tries >= 1)
                    {
                        if (playerGuess > generatedNumber)
                        {
                            Console.WriteLine("Du gissade för högt!");
                            playerGuess = Convert.ToInt32(Console.ReadLine());
                            tries--;
                            Console.WriteLine($"Du har nu {tries} försök kvar");
                        }

                        if (playerGuess < generatedNumber)
                        {
                            Console.WriteLine("Du gissade för lågt!!");
                            playerGuess = Convert.ToInt32(Console.ReadLine());
                            tries--;
                            Console.WriteLine($"Du har nu {tries} försök kvar");
                        }

                    }

                    if (playerGuess == generatedNumber)
                    {
                        Console.WriteLine("Du gissade rätt, Grattis!");

                        if (Playagain() == "JA")
                        {

                        }

                        else
                        {
                            game = false;
                        }

                    }

                    if (tries <= 0)
                    {
                        Console.WriteLine("De är slut.");
                        if (Playagain() == "JA")
                        {

                        }

                        else
                        {
                            game = false;
                        }

                    }

                }


            }

        }



    }
}
