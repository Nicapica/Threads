//Author: Nicholas Pica
//File: FindPiThread.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class FindPiThread
    {
        int DartsNeeded = 0;
        int DartsThrown = 0;
        Random newRandom;

        // This funtion is a constructor that creates the random number generator.
        public FindPiThread(int dartsneeded)
        {
            DartsNeeded = dartsneeded;
            newRandom = new Random();
        }
        //this funtions uses the random number generator that we created in the constructor to "throw" the darts
        public void ThrowDarts()
        {
            for (int i = 0; i <= DartsNeeded; i++)
            {
                double x = newRandom.NextDouble();
                double y = newRandom.NextDouble();
                double z = x * x + y * y;

                if (z <= 1)
                {
                    DartsThrown = DartsThrown + 1;
                }

            }
        }

        public int DartsInside
        {
            get {return DartsThrown;}
            set {DartsThrown = value;}
        }
    }
}
