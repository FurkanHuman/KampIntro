using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrencisyisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapildimi = true;

            double dolarnDun = 7.35;
            double dolarbugun = 7.45;

            if(dolarnDun>dolarbugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarnDun<dolarbugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }








            if (sistemeGirisYapildimi==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
                
            }

            else
            {
                Console.WriteLine("Siteme Giriş Yap");
            }
            Console.WriteLine(kategoriEtiketi);

            Console.ReadKey();
        }
    }
}
