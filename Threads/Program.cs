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
            Console.WriteLine("How many throws should each thread make?");
            Console.ReadLine();
            Console.WriteLine("How many threads would you like to run?");
            Console.ReadLine();

            List<Thread> thread = new List<Thread>();
            List<FindPiThread> fpiThread = new List<FindPiThread>();

            foreach()
            {
                fpiThread.Add();
                thread.Add();
                Thread.Sleep(16);
            }

            foreach(int item in fpiThread)
            {
                Console.WriteLine(item);
                item.Join();
            }

            foreach(int item in thread)
            {
                Console.WriteLine(item);
            }
        }
    }
}
