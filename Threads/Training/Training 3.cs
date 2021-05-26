using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Training3
    {
        public static int alarms { get; set; }

        static void Main(string[] args)
        {
            // Initialize new Program object
            Training3 pg = new Training3();

            // Initialize new Thread object
            Thread thread1 = new Thread(new ThreadStart(pg.Method1));

            // Start thread
            thread1.Start();

            // While loop
            while(true)
            {
                // Wait 10 seconds
                Thread.Sleep(10000);

                // Output thread1 state
                Console.WriteLine("thread1 State: " + thread1.ThreadState);

                // Check if thread1 is dead
                if(!thread1.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
            }

            Console.Read();
        }

        public void Method1()
        {
            // Initialize new Random object
            Random rg = new Random();

            // While loop if alarms is less than 3
            while (alarms < 3)
            {
                // Sleep current thread for 2 seconds
                Thread.Sleep(2000);

                // Generate a random temp betweenv -20 and 120
                int temp = rg.Next(-20, 120);

                // Output the temp
                Console.WriteLine(temp);

                // Check if the temp is at the legal range
                if (temp < 0 || temp > 100)
                {
                    alarms += 1;
                }
            }
        }
    }
}
