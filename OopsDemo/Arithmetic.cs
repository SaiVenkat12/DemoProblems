using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class Arithmetic:add
    {
        public override void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("PolyMorphism Addition:" + c);
        }
    }
}
