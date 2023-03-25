using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithThread
{
    public class Example4
    {
        static void Main(string[] args)
        {
            Thread tt = new Thread(Rotina);
            tt.Start();
            // espera a thread terminar
            tt.Join();
        }

        static void Rotina()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine("example");
        }
    }
}
