using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlemeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlemeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlemeOrani = 85;

            //Console.WriteLine(kurs1.KursAdi + kurs1.Egitmen + kurs1.IzlemeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var Kurs  in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi+" : "+Kurs.Egitmen+" : "+Kurs.IzlemeOrani);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }
    }
}
