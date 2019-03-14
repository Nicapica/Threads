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
        int DartsThrown { get; }
        Random newRandom;

        public FindPiThread(int dartsneeded)
        {
            DartsNeeded = dartsneeded;
            Random random = new Random();
        }

        public void ThrowDarts()
        {
            for (int ctr = 0; ctr <= 100000; ctr++);
        }
    }
}
