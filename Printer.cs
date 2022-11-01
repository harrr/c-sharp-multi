using System;
using System.Threading;

namespace Miltithreading
{
    public class Printer
    {
            object threadlock = new Object();
            public void PrintNumbers()
            {
                lock(threadlock)
                {
                    Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

                    for(int i = 0; i < 10; i++)
                    {
                        Random r = new Random();
                        Thread.Sleep(1000 * r.Next(5));
                        Console.Write("{0}, ", i);
                    }
                    Console.WriteLine();
                }
            }
    }
}