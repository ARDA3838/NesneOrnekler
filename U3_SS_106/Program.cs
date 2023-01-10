using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    abstract class Kutuphane
    {
        public string KitapAdi { get; set; }
        public string DergiAdi { get; set; }
        public string AnsiklopediAdi { get; set; }
        public abstract void Oku();

    }

    class Dergi : Kutuphane
    {
        public string Ad { get; internal set; }

        public override void Oku()
        {
            Console.Write("OVERRİDE İLE OKUNDU");
        }
    }
    class Ansiklopedi: Kutuphane
    {
        public string Ad { get; set; }

        public override void Oku()
        {
            Console.Write("OVERRİDE İLE OKUNDU");
        }
    }

    internal class Kitap : Kutuphane
    {
        public string Ad { get; set; }

        public override void Oku()
        {
            Console.Write("OVERRİDE İLE OKUNDU");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dergi dergi = new Dergi();
            dergi.KitapAdi = "Derin Tarih";
            Console.WriteLine("{0} Adlı Dergi", dergi.KitapAdi);

            Kitap kitap = new Kitap();
            kitap.KitapAdi = "Huzur Sokağı";
            Console.WriteLine("{0} Adlı Kitap", kitap.KitapAdi);

            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.KitapAdi = "Meydan Louresse";
            Console.WriteLine("{0} Adlı Ansiklopedi", ansiklopedi.KitapAdi);

            Console.ReadLine();
        }
    }
}
