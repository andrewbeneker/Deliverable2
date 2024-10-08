

using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Coin Flip Challenge!");
        Console.WriteLine();
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Hello, " + userName);
        Console.WriteLine("Would you like to play the Coin Flip Challenge? Yes or No?") ;
            string yesNo = Console.ReadLine();
        if (yesNo == "Yes")
        {
            Console.WriteLine("Let's play!");

            int numWins = 0;

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Heads or Tails?");
                string guess = Console.ReadLine();

                Random coinFlip = new Random();
                int randomNumber = coinFlip.Next(1, 3);
                
                {
                    if (randomNumber == 1 && guess == "Heads")
                    {
                        Console.WriteLine("It was heads, you guessed correctly!");
                        Console.WriteLine() ;
                        numWins++;

                    }

                    else if (randomNumber == 2 && guess == "Tails")
                    {

                        Console.WriteLine("It was Tails, you guessed correctly!");
                        Console.WriteLine();
                        numWins++;
                    }
                    else if (randomNumber == 1 && guess == "Tails")
                    {
                        Console.WriteLine("It was Heads, wrong choice!");
                        Console.WriteLine() ;
                    }
                    else if (randomNumber == 2 && guess == "Heads")
                    {
                        Console.WriteLine("It was Tails, wrong choice!");
                        Console.WriteLine() ;
                    }

                }

             
            }

            {
                Console.WriteLine() ;
                Console.WriteLine("The challenge is over. Your score is: " + numWins);
            }    


            }
           
        else
        {
            Console.WriteLine("You are a coward, " + userName);
        }


    }
}