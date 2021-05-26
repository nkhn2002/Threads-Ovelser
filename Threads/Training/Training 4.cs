using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Training4
    {
        public static char ch { get; set; } = '*';
        static void Main(string[] args)
        {
            // Declare new Program
            Training4 pg = new Training4();

            // Declare new Thread
            Thread thread1 = new Thread(new ThreadStart(pg.Method1));

            // Start thread
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(pg.Method2));
            thread2.Start();
        }

        public void Method1()
        {
            while(true)
            {
                Thread.Sleep(200);
                Console.Write(ch);
            }
        }

        public void Method2()
        {
            while(true)
            {
                ch = char.Parse(Console.ReadLine());
            }
        }
    }
}
