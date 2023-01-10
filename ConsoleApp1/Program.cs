using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OkulPersoneli
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }
    }
    class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OkulPersoneli per = new OkulPersoneli();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "Serkan";
            ogrt.Soyad = "Aydın";
            ogrt.Brans = "Bilisim";
            Console.WriteLine("öğretmen sınıftan türetilen {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);

            per.Ad = "Ramazan";
            per.Soyad = "Güneş";

            Console.WriteLine("OkulPersoneli sınıftan türetilen {0} {1}", per.Ad, per.Soyad);

            Console.ReadLine();
        }
    }
}
