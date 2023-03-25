using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithThread
{
    public class Example3
    {
        static bool ok;
        static readonly object bloqueador = new object();

        static void Main(string[] args)
        {
            new Thread(NovaRotina).Start();
            NovaRotina();
            Console.ReadKey();
        }

        static void NovaRotina()
        {
            lock (bloqueador)
            {
                if (!ok)
                {
                    Console.WriteLine("example");
                    ok = true;
                }
            }
        }

    }
}
