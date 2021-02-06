using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist.net
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(7);
            a.Add(8);
            a.Remove(0);
            Console.WriteLine(a[0]);
        }
    }
}
