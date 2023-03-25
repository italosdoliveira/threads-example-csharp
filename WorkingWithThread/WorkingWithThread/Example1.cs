using System;
using System.Threading;

namespace WorkingWithThread
{
    class Example1
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(NovaThread);
            t.Start();

            for (int i = 0; i < 1000; i++) Console.WriteLine("1");

        }

        static void NovaThread()
        {
            for (int i = 0; i < 1000; i++) Console.WriteLine("2");
        }
    }
}
