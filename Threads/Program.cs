//Author: Nicholas Pica
//File: Program.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prompts the user with questions that define how many throws to make per thread and how many threads to run in total.
            Console.WriteLine("How many throws should each thread make?");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many threads would you like to run?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            double temp = 0;
            
            // These lists are filled based upon what the user inputs
            List<Thread> thread = new List<Thread>();
            List<FindPiThread> fpiThread = new List<FindPiThread>();

            for(int i = 1; i <= answer2; i++)
            {
                FindPiThread objFPiThread = new FindPiThread(answer1);
                fpiThread.Add(objFPiThread);
                Thread myThread;
                myThread = new Thread(new ThreadStart(objFPiThread.ThrowDarts));
                thread.Add(myThread);
                myThread.Start();
                Thread.Sleep(16);
            }

            // This loop runs through every item in the fpiThread list
            foreach(FindPiThread item in fpiThread)
            {
                double dartsinside = item.DartsInside;
                Console.WriteLine(item.DartsInside);
                double PiEstimate = (dartsinside / answer1) * 4;
                temp = PiEstimate + temp;
                if (item == fpiThread.Last())
                {
                    PiEstimate = temp / answer2;
                    Console.WriteLine("The estimation for pi is: ");
                    Console.WriteLine(PiEstimate);
                }
            }

            // This loop runs through every item in the thread list
            foreach (Thread item in thread)
            {
                item.Join();
            }
            Console.ReadKey();
        }
    }
}
