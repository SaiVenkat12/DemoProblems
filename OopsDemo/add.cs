using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class add
    {
        public virtual void Add(int a,int b)
        {
            int sum = a + b;

            Console.WriteLine("Addition: "+sum);
        }
    }
}
