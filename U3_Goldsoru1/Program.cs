using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_Goldsoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double cevre, alan, r;
            Console.Write("Yarıçapı Gir : ");
            r = Convert.ToDouble(Console.ReadLine());
            cevre = 2 * pi * r;
            alan = pi * r * r;
            Console.WriteLine("===============================");
            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("Çevre: " + cevre);
            Console.ReadKey();
        }
    }
    class Daire
    {
        private int a, b;
        public Daire(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a * b;
        }
        public int CevreHesapla()
        {
            return 2 * (a + b);
        }
    }
}
// İLK BEN YAPTIIIIM ş