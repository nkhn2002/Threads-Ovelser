using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Training1_2
    {
        static void Main(string[] args)
        {
            // Declare new Program
            Training1_2 pg = new Training1_2();

            // Declare new Thread
            Thread thread1 = new Thread(new ThreadStart(pg.CSharpThreadigIsEZ));

            // Set thread name
            thread1.Name = "Thread 1";

            // Start Thread
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(pg.Method1));
            thread2.Start();

            Console.Read();
        }

        public void CSharpThreadigIsEZ()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"C#-trådning er nemt!");
            }
        }

        public void Method1()
        {
            for(int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Også med flere tråde...");
            }
        }
    }
}
