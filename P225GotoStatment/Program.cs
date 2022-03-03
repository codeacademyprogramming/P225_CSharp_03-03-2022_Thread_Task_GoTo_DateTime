using System;
using System.Globalization;
using System.Threading;

namespace P225GotoStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int count = 0;

            //asdasd:

            //    Console.WriteLine("Test");

            //    if (count == 0)
            //    {
            //        count++;
            //        goto asdasd;
            //    }

            //DateTime dateTime = new DateTime();

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.UtcNow.AddHours(3));
            Console.WriteLine(DateTime.UtcNow.AddDays(3));

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");


            Console.WriteLine(DateTime.Now.ToString("ddd -- MMMM -- yyyyy"));
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss:fffffff"));
            Console.WriteLine(DateTime.Now.Hour);

        }
    }
}
