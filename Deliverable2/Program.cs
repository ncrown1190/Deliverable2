// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("        *********************************   \n");
        Console.WriteLine("        Welcome to the COIN FLIP CHALLENGE. \n");
        Console.WriteLine("        *********************************   \n");

        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        //Console.WriteLine(name);
        Console.WriteLine("Welcome " +  name + ". Do you want to play the COIN FLIP CHALLENGE? Yes/No ");

        string challengAgree = Console.ReadLine();
        //Console.WriteLine(challengAgree);

        if (challengAgree.ToLower() == "no")
        {
            Console.WriteLine("You are a coward " +  name + ".");
        }
        else if(challengAgree.ToLower().Equals("yes"))
        {
            Console.WriteLine("Lets Begin the game " + name + ". ");

            int score = 0;

            Random coinFlip = new Random();

            for (int i = 0; i < 5; i++)
            {
                int result = coinFlip.Next(0, 2);

                Console.WriteLine("Heads or Tails ");

                string playerGuess = (Console.ReadLine()).ToLower();

                if(playerGuess == "heads" || playerGuess == "tails")
                {
                    if((result == 0 && playerGuess == "heads") ||  (result == 1 && playerGuess == "tails"))
                    {
                        score++;
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                }
                else
                {
                    i--;
                    Console.WriteLine("Invalid input. Please enter either 'Heads' or 'Tails'. ");
                }
            }

            Console.WriteLine("Thank you " + name + ". You got a score of " + score + " !");
            

        }
        
    }
}
