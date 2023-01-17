using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_109
{
    interface ISekil
    {
        void Ciz();
    }
    class Kare : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("kare çiz");
        }
    }
    class Daire : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("daire çiz");
        }
    }
    class Ucken : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("üçken çiz");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<sekil> sekiller = new List<sekil>
            {
                new Daire(),
                new Kare(),
                new Ucken()
            };
            foreach (var sekil in sekiller)
            {
                sekil.Ciz();
            }
        }
    }
}