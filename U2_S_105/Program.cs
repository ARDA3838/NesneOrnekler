using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_S_105
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }
        public abstract void Calis();
        public abstract void Dur();
    }
    public class Otomobil : MotorluArac
    {
        public bool OtomatikVites { get; set; }
        public override void Calis()
        {
            Console.WriteLine("Otomobil çalıştı.");
        }
        public override void Dur()
        {
            Console.WriteLine("Otomobil durdu.");
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Otomobil oto = new Otomobil();
            }        
        }
    }

            