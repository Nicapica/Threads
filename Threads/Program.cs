//Author: Nicholas Pica
//File: Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.ReadLine();
            Console.WriteLine("How many threads would you like to run?");
            Console.ReadLine();

            List<Thread> thread = new List<Thread>();
            List<FindPiThread> fpiThread = new List<FindPiThread>();

            foreach()
            {
                fpiThread.Add();
                thread.Add(myThread);
                myThread.Start();
                Thread.Sleep(16);
            }

            // This loop runs through every item in the fpiThread list
            foreach(FindPiThread item in fpiThread)
            {
                int inside = item.DartsInside;
                Console.WriteLine(item.DartsInside);
                item.Join();
            }

            // This loop runs through every item in the thread list
            foreach (Thread item in thread)
            {
                Console.WriteLine(item);
            }
        }
    }
}
