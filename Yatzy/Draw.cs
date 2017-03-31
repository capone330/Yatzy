using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Yatzy
{
    class Draw
    {
        private static Random rnd = new Random();
        public static bool DrawBoard(DicePool pool)
        {

            //for (int k = 0; k < 20; k++)
            //{
            //    BackgroundColor = ConsoleColor.DarkBlue;
            //    Clear();
            //    ForegroundColor = ConsoleColor.White;
            //    ForegroundColor = ConsoleColor.White;
            //    for (int i = 1; i < 6; i++)
            //    {
            //        Write(" " + i + " ");
            //    }
            //    WriteLine("");
            //    for (int i = 1; i < 6; i++)
            //    {

            //        if (pool.IsLock(i) == false) {
            //            ForegroundColor = ConsoleColor.Green;
            //            Write("[" + rnd.Next(1, 7) + "]");

            //        } else {
            //            ForegroundColor = ConsoleColor.Red;
            //            Write("[" + pool.GetDiceValue(i) + "]");
            //        }

            //    }
            //    ForegroundColor = ConsoleColor.White;
            //    WriteLine("");
            //    WriteLine("");
            //    WriteLine("Tryk 1 - 5, for at låse terning.");
            //    WriteLine("");
            //    WriteLine("Tryk Space for at rulle terningerne.");
            //    WriteLine("");
            //    WriteLine("Tryk 0 for at afslutte.");
            //    Thread.Sleep(100);
            //}

            

            BackgroundColor = ConsoleColor.DarkBlue;
            Clear();

            string result = pool.CheckResult();
            if (result != "")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(result);
                //Beep();
                ForegroundColor = ConsoleColor.White;

            }
            else
            {
                WriteLine("");

            }

            ForegroundColor = ConsoleColor.White;
            for (int i = 1; i < 6; i++)
            {
                Write(" " + i + " ");
            }
            WriteLine("");
            for (int i = 1; i < 6; i++)
            {

                if (pool.IsLock(i) == false) { ForegroundColor = ConsoleColor.Green; } else { ForegroundColor = ConsoleColor.Red; }
                Write("[" + pool.GetDiceValue(i) + "]");
            }
            ForegroundColor = ConsoleColor.White;

            WriteLine("");
            int diceRollCount = pool.DiceRollCount;
            WriteLine("Forsøg " + diceRollCount);

            WriteLine("");
            WriteLine("Mulige kompination:");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("1 par");
            WriteLine("2 par");
            WriteLine("3 ens");
            WriteLine("4 ens");
            WriteLine("Lille Straight");
            WriteLine("Stor Straight");
            WriteLine("Fuldt hus");
            WriteLine("Change");
            WriteLine("Yatzy");
            ForegroundColor = ConsoleColor.White;
            WriteLine("");
            WriteLine("");
            WriteLine("");
            for (int i = 26; i < Console.WindowHeight; i++)
            {
                WriteLine("");
            }
            Write("Tryk 1 - 5, for at låse terning.                ");
            Write("Tryk N for ny runde.");
            WriteLine("");
            WriteLine("Tryk Space for at rulle terningerne.");
            WriteLine("");
            WriteLine("Tryk 0 for at afslutte.");
            WriteLine("");
            WriteLine("");
            WriteLine("Created by Jonas Gregersen");
   


            return true;
        }


    }
}
