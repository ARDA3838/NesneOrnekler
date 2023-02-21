using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_115
{
    enum Seviyeler
    {
        çok_düşük, // 0
        düşük, // 1
        orta, // 2
        yüksek, //3
        çpk_yüksek // 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Seviyeler.düşük);
            Console.WriteLine((int)Seviyeler.düşük);
            Console.ReadLine();
        }
    }
}
