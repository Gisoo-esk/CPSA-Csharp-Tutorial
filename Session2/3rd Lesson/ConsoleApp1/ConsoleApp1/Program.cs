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
            {  یک تابع برای تماخاب تصادفی باید انتخاب کنیم مثل تابع رندوم داخل تابع از زمان استفاده میکنیم  دقیقه ها بین صفر تا نه هستن و ثانیه لحظه اول با ثانیه احظه دوم فرق دار  پس برای دو تا عدد رندوم از ثانیه لحظه لول و احظه دوم در نظر میگیریم رندوم یکی رو انتخاب  میکنیم 
                Random random = new Random(Guid.NewGuid().GetHashCode());
                value = random.Next(1, 6); مثدار رندوم ب دست اورده میزاریم توی مقدار 
                return value;
            }
        }
        class Player
        {
            private string playerName;
            private int playerValue; عدد تاس یرای کاربر
            public int Score { get; set; }
امتیاز کاربر
            public Player(string playerName)
            {
                this.playerName = playerName;
                this.Score = 0;
            }
            public void rollDice()
            {مقدار عدد تاس کابر رو میزاریم توی تابع رول و بازی انجام میشه 
                Dice dice = new Dice();
                this.playerValue = dice.roll();
            }
            public int showValue()
            { عدد تاس کاربر نشان میده 
                return this.playerValue;
            }
        }

        static void Main(string[] args)
        {  این کد ها برای لود شدندوقتی متظری وارت ص بعدی بشه یک چیری ب نشانه لودینکدمیاد روی صفحه 
            char[] loading = { '|', '/', '-', '\\'};
            Console.ForegroundColor = ConsoleColor.Yellow;
            Player aiPlayer = new Player("AI");
         یک نتغیر از جنس کلاس تعریف کرده مقدار داده بهش ب عنوان کاربر سیستم در نطر میگیری 
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
                    { این فور براس همون لودینگ یعنی لود شدن هر نود صدم ثانیه فککنم علامت عوض مسشه 
                        foreach (var item in loading)
                        {
                            Console.Write(item);
                            Thread.Sleep(90);
                            Console.Clear();
                        }
                        
                    } 
                    player.rollDice(); کابر اول دوم میره توی تابع رول بازی انجم میشه 
                    aiPlayer.rollDice();
                    if (player.showValue() > aiPlayer.showValue())
                    { اگر مقدار کاربر از سیستم بررگ تز بود یکی ب امتیاز اضافه کن بگو ک بزنده شده
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
                    { پیغام مساوی بودن
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
