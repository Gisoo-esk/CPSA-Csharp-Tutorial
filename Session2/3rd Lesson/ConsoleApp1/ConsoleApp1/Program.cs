using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Create a dice game
        // user and AI Should BE OOP
        class Dice
        {
            private int value;
            
            public int roll()
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                value = random.Next(1, 6);
                return value;
            }
        }
        class Player
        {
            private string playerName;
            private int playerValue;
            public int Score { get; set; }

            public Player(string playerName)
            {
                this.playerName = playerName;
                this.Score = 0;
            }
            public void rollDice()
            {
                Dice dice = new Dice();
                this.playerValue = dice.roll();
            }
            public int showValue()
            {
                return this.playerValue;
            }
        }

        static void Main(string[] args)
        {
            char[] loading = { '|', '/', '-', '\\'};
            Console.ForegroundColor = ConsoleColor.Yellow;
            Player aiPlayer = new Player("AI");
            Console.Write("Please Enter Your Name : ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Console.Clear();
            
            while (true)
            {
                try
                {
                    Console.Write("Press Enter to Roll a Dice");
                    Console.ReadLine();
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        foreach (var item in loading)
                        {
                            Console.Write(item);
                            Thread.Sleep(90);
                            Console.Clear();
                        }
                        
                    }
                    player.rollDice();
                    aiPlayer.rollDice();
                    if (player.showValue() > aiPlayer.showValue())
                    {
                        player.Score++;
                        Console.WriteLine("You win");
                        return;
                    }
                    else if (aiPlayer.showValue() > player.showValue())
                    {
                        aiPlayer.Score++;
                        Console.WriteLine("AI Wins");
                    }
                    else
                    {
                        Console.WriteLine("Equals!!!");
                    }
                }
                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e);
                }
            }

        }
    }
}
