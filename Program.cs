using System;


public class Program
{
    
    public static void Main(string[]  args)
    {
        Intro();
        

    }

    public static void Intro()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine("");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
        Console.WriteLine("where you will each roll a 6-sided dice, and the player ");
        Console.WriteLine("with the highest dice value will win the round. The player ");
        Console.WriteLine("who wins the most rounds wins the game. Good luck!");
        Console.WriteLine("");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey(true);
    }

    public static int RollDice()
    {
        Random diceRoll = new Random();
        int rollNumber = diceRoll.Next(1, 7);
        return rollNumber;
    }

    public static void RoundOne()
    {
        int playerScore = 0;
        int rivalScore = 0;

        Console.WriteLine("Round 1");
        int rivalRoll = RollDice();
        Console.WriteLine($"Rival rolled a {rivalRoll}");
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey(true);
        int playerRoll = RollDice();
        Console.WriteLine($"You rolled a {playerRoll}");

        if(rivalRoll > playerRoll)
        {
            Console.WriteLine("The Rival won this round.");
            rivalScore++;
        }
        else if(playerScore > rivalScore)
        {
            Console.WriteLine("You won this round.");
            playerScore++;
        }
        else
        {
            Console.WriteLine("This round was a draw!");
        }
    }
}