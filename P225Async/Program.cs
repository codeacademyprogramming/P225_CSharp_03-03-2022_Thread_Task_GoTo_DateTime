using System;
using System.Threading;

namespace P225Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Login);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            //Loop1();
            //Login();
        }

        static void Loop1()
        {
            //Thread.Sleep(1000);

            ulong result = 0;

            for (ulong i = 0; i < 100; i++)
            {
                Console.WriteLine($"Method: loop1 {result}");
            }
        }

        static void Login()
        {
            ulong result = 0;

            //Thread.Sleep(0);
            //Thread.Yield();

            for (ulong i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);

                Console.WriteLine($"Method: loop2 {result}");
            }
        }
    }
}
