using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class DicePool
    {

        private Terning[] dicePool = new Terning[5];
        private int diceRollCount;


        public int DiceRollCount
        {
            get { return diceRollCount; }
            private set { diceRollCount += value; }
        }

        public void ResetRollCount()
        {
            diceRollCount = 0;
        }

        public void ResetLockedDice()
        {
            for (int i = 0; i < 5; i++)
            {
                dicePool[i].ChangeLockStatus(false);
            }
        }

        public DicePool()
        {
            for (int i = 0; i < 5; i++)
            {
                dicePool[i] = new Terning();
            }
        }

        public void LockDice(int diceNr)
        {
            dicePool[diceNr - 1].ChangeLockStatus();
        }

        public int GetDiceValue(int diceNr)
        {
            return dicePool[diceNr - 1].GetDiceValue();
        }

        public bool IsLock(int diceNr)
        {
            return dicePool[diceNr - 1].IsLock();
        }

        public void Roll()
        {
            for (int i = 0; i < 5; i++)
            {
                if (dicePool[i].IsLock() == false)
                    dicePool[i].RoolDice();
            }
            this.DiceRollCount = 1;
        }

        public string CheckResult()
        {
            string bestScore = "";
            bool houseReady = false;
            bool smalStraightReady = true;
            bool bigStraightReady = false;
            int[] row = { 0, 0, 0, 0, 0, 0 };
            foreach (Terning dice in dicePool)
            {
                row[dice.GetDiceValue() - 1] += 1;

            }

            for (int k = 0; k < 6; k++)
            {
                if (row[k] == 2)
                {
                    bestScore = "1 par";
                    if (houseReady == true)
                        bestScore = "2 par";
                    houseReady = true;
                    
                }
            }

            for (int k = 0; k < 5; k++)
            {
                if (row[k] != 1)
                {
                    smalStraightReady = false;
                    bigStraightReady = true;
                    for (int l = 1; l < 6; l++)
                    {
                        if (row[l] != 1)
                        {
                            bigStraightReady = false;
                            
                        }
                    }
                }
            }

            if(smalStraightReady)
                bestScore = "Lille Straight";
            if(bigStraightReady)
                bestScore = "Stor Straight";

            for (int k = 0; k < 6; k++)
            {
                if (row[k] == 5)
                { bestScore = "YATZY!!!!"; }
                else if (row[k] == 4)
                { bestScore = "4 Ens"; }
                else if (row[k] == 3)
                {
                    if (houseReady == true)
                        bestScore = "Fuldt hus";
                    else
                        bestScore = "3 Ens";
                }
            }

            return bestScore;
        }

    }
}
