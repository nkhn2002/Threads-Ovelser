using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Training0
    {
        static void Main(string[] args)
        {
            // Initialize new Program object
            Training0 pg = new Training0();

            // Initialize new Thread object
            Thread thread1 = new Thread(new ThreadStart(pg.WorkThreadFunction));

            // Set thread name
            thread1.Name = "Thread 1";

            // Start thread
            thread1.Start();

            // Thread 2
            Thread thread2 = new Thread(new ThreadStart(pg.WorkThreadFunction));
            thread2.Name = "Thread 2";
            thread2.Start();

            Console.Read();
        }

        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"simple Thread - ({Thread.CurrentThread.Name})");
            }
        }
    }
}
