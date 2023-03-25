using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithThread
{
    public class Example2
    {
        static void Main(string[] args)
        {
            new Thread(NovaThread).Start();

            Console.ReadKey();
        }

        static void NovaThread()
        {
            for (int i = 0; i < 5; i++) 
                Console.WriteLine("2");
        }
    }
}
