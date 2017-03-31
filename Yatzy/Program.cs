using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            DicePool pool = new DicePool();
            do
            {
                
                Draw.DrawBoard(pool);
                
                ConsoleKeyInfo userInput = new ConsoleKeyInfo();
                userInput = ReadKey(true);
                switch (userInput.Key)
                {
                    case ConsoleKey.Spacebar:
                        pool.Roll();
                        break;
                    case ConsoleKey.D1:
                        pool.LockDice(1);
                        break;
                    case ConsoleKey.D2:
                        pool.LockDice(2);
                        break;
                    case ConsoleKey.D3:
                        pool.LockDice(3);
                        break;
                    case ConsoleKey.D4:
                        pool.LockDice(4);
                        break;
                    case ConsoleKey.D5:
                        pool.LockDice(5);
                        break;
                    case ConsoleKey.N:
                        pool.ResetRollCount();
                        pool.ResetLockedDice();
                        break;
                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
 
            } while (true);

        }
    }
}
