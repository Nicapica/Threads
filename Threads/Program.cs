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
            List<FindPiThread> piThreads = new List<FindPiThread>();
        }
    }
}
