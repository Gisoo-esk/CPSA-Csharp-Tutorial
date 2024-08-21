using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Creating a tictacttoe Game with Classes
        public class Player
        { 
            public string Name {  get; set; }
            public bool IsCircle { get; private set;{فیلد برای نماد بازیکن هاست  
            public Player(string name, bool isCircle) 
            { تابع سازنده 
                this.Name = name;
                this.IsCircle = isCircle;
            }
            
        }

        public class Board
        {
            private bool?[,] boardArray = new bool?[3, 3];
            ذرست کردن یک ارایه دو بعدی 
            public Board()
            {
                for (int i = 0; i < boardArray.GetLength(0); i++)
                { برای ارایه های دو بعدی توی فور اینطوری سقف شو مشخص میکنیم 
                    for(int j = 0; j < boardArray.GetLength(1); j++)
                    {
                        boardArray[i, j] = null;
                        ارایه رو خالی کرد صفحه بازی خالی کرد 
                    }
                }
            }
            public bool playAt(Player player, int x, int y)
            {
                if (x <= 3 && y <= 3 && x > 0&& y > 0)
                { چون کاربرد عددی ک وارد میکنه
                    یین عدد یک و دو و سه است شیستم از صفر ظروع شده ارایه اش یکی از عدد کاربذد کم میکنه 
                    x--;
                    y--;
                    if (boardArray[x, y] == null)
                    {
                        this.boardArray[x, y] = player.IsCircle;
                        return true;
             توشاگر اون خونه ای که کاربرد انتخاب کرده بود خالی بود نماد شو  کاربرد بژار نچش 
                    }
                }
                
                Console.WriteLine("Illegal Move Press Enter to Continue");
                Console.ReadLine();
                return false;
                اگر اون حونه پر باشه ازور میده 
            }
            public bool winCheck(Player player)
            { این تابع چک‌میکنخ که برنده شدیم یا نه 
                bool isCircle = player.IsCircle;
نماد بازیگن میزاره توی متغیر 
                // Check rows
                for (int i = 0; i < 3; i++)
                { چهار حالت برنده میشیم   یا ضرب دری یا سه سطری یا سه ستونی اللن داره حالت سه سطری چک می‌کنه
                    if (boardArray[i, 0] == isCircle && boardArray[i, 1] == isCircle && boardArray[i, 2] == isCircle)
                    {
                        return true;
                    }
                }

                // Check columns
                for (int i = 0; i < 3; i++)
                {حالت سه ستون چک میکنه 
                    if (boardArray[0, i] == isCircle && boardArray[1, i] == isCircle && boardArray[2, i] == isCircle)
                    {
                        return true;
                    }
                }

                // Check diagonals
                if ((boardArray[0, 0] == isCircle && boardArray[1, 1] == isCircle && boardArray[2, 2] == isCircle) ||
                    (boardArray[0, 2] == isCircle && boardArray[1, 1] == isCircle && boardArray[2, 0] == isCircle))
                { حالت ضرب دری چک می‌کنه 
                    return true;
                }

                return false; // No winning condition met
            }
           
            public void displayBoard()
            {
                Console.Clear();
                for (int i = 0; i < boardArray.GetLength(0); i++)
                { داره مشخص میکنه نماد تو چیه  و خونه ای که امتخاب کردی اگر مشاوی فالس باشه یعنی ایکس 
                    for (int j = 0; j < boardArray.GetLength(1); j++)
                    {
                        if (boardArray[i, j] == false)
                        {
                            Console.Write(" X ");
                        }
                        else if (boardArray[i, j] == true)
                        {
                            Console.Write(" O ");
                        }
                        else
                        {
                            Console.Write(" . ");
                        }    
                    }
                    Console.WriteLine();
                }
            }

            public bool isFinished()
            { تابع که چگ‌میکنه بازی کشی برده یا نه
                for (int i = 0; i < boardArray.GetLength(0); i++)
                {
                    for (int j = 0;j < boardArray.GetLength(1); j++)
                    {
                        if (this.boardArray[i, j] == null)
                        {
                            return false;
                            اگر یک خونه هم بتشه که توش ایکس یا صفر نباشع سعنی بازی تموم نشده 
                        }
                    }
                }
                return true;
            }

        }


        static void Main(string[] args)
        {
            
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    Console.Write("Please enter your name For Player 1 : ");
                    Player player1 = new Player(Console.ReadLine(), true);
                    Console.Clear();
                    Console.Write("Please enter your name For Player 2 : ");
                    Player player2 = new Player(Console.ReadLine(), false);

                    Board board = new Board();
                    int x, y;

                    while (true)
                    {

                        if (board.isFinished())
                        { تابع چک صدا میژنه بیینه بازی تموم شده یا نه 
                            Console.WriteLine("Game has finished Press Enter to Play Agian");
                            Console.ReadLine();
                            break;
                        }
                        board.displayBoard();
مشخص میکنه نماد بازیکن ها چیه 
                        Console.Write("Player 1 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Player 1 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        board.playAt(player1, x, y);
                        دو تا عددی که گرفته  و اسم کاربرد میبرن نوی تابع پلی ات تابع بازی 
                        board.displayBoard();

                        if (board.winCheck(player1))
                        {
                            Console.WriteLine("Done!!!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                        board.displayBoard();
                        Console.Write("Player 1 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Player 1 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        board.playAt(player2, x, y);
                        board.displayBoard();
                        if (board.winCheck(player2))
                        {
                            Console.WriteLine("Done!!!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ e.Message} Press Enter To Start Over !!!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
