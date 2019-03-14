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
            Console.WriteLine("Darts inside each thread: ");
            double temp = 0;
            
            // These lists are filled based upon what the user inputs
            List<Thread> thread = new List<Thread>();
            List<FindPiThread> fpiThread = new List<FindPiThread>();

            for(int i = 1; i <= answer2; i++)
            {
                // creates an object for FindPiThread with answer1 inside so it knows how many darts to throw based on the users answer
                FindPiThread objFPiThread = new FindPiThread(answer1);
                //adds the object to the fpiThread list.
                fpiThread.Add(objFPiThread);
                Thread myThread;
                myThread = new Thread(new ThreadStart(objFPiThread.ThrowDarts));
                thread.Add(myThread);
                myThread.Start();
                Thread.Sleep(16);
            }

            // this loops through every item in the fpiThread list.
            foreach(FindPiThread item in fpiThread)
            {
                // this finds out just how many darts landed inside and then outputs them per thread.
                double dartsinside = item.DartsInside;
                Console.WriteLine(item.DartsInside);
                double PiEstimate = (dartsinside / answer1) * 4;
                temp = PiEstimate + temp;
                if (item == fpiThread.Last())
                {
                    //
                    PiEstimate = temp / answer2;
                    Console.WriteLine("The estimation for pi comes out to be: ");
                    Console.WriteLine(PiEstimate);
                }
            }

            // This loop runs through every item in the thread list
            foreach (Thread item in thread)
            {
                // this tell the main to wait until every other thread is finished before it continues.
                item.Join();
            }
            // this keeps the console open until another key is pressed to close it.
            Console.ReadKey();
        }
    }
}
