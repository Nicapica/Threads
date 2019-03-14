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
        int dartsinside;
        Random newRandom;

        public FindPiThread(int dartsneeded)
        {
            DartsNeeded = dartsneeded;
            Random random = new Random();
        }

        public void ThrowDarts()
        {
            for (int i = 0; i <= DartsThrown; i++)
            {
                double x = newRandom.NextDouble();
                double y = newRandom.NextDouble();
                double z = x * x + y * y;

                if (z <= 1)
                {
                    dartsinside = dartsinside + 1;
                }

            }
        }

        public int DartsInside
        {
            get
            {
                return dartsinside;
            }
            set
            {
                dartsinside = value;
            }
        }
    }
}
