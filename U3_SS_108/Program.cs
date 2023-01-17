using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_108
{
    interface IKütüphane
    {
        void Oku();
    }
    public class Kitap : IKütüphane
    {
        public void Oku()
        {
            Console.WriteLine("kitap Oku");
        }
    }
    public class Dergi : IKütüphane
    {
        public void Oku()
        {
            Console.WriteLine("Dergi Oku");
        }
    }
            public class Ansiklopedi : IKütüphane
            {
                public void Oku()
                {
                    Console.WriteLine("Ansiklopedi Oku");
                }
            }
    class Program
    {
        static void Main(string[] args)
        {
                Kitap kitap = new Kitap();
                    kitap.Oku();


                Dergi dergi = new Dergi();
                    dergi.Oku();


                Ansiklopedi ansiklopedi = new Ansiklopedi();
                    ansiklopedi.Oku();


                    Console.WriteLine("=======================");


            Console.ReadLine(); 
        }
    }
}
