using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xard.sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpb = new CardPoolBuilder();
            cpb.PushDeck();
            var cp = cpb.Build();
            var p1 = cp.containers[0];
            foreach(var c in p1.Cards)
            {
                Console.WriteLine(c);
            }
        }
    }
}
