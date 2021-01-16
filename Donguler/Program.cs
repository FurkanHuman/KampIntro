using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {
                "Yazılım Geliştirici Yetiştirme kampı", 
                "Programlama Başlangıç Temel ", 
                "kurs 3" ,"kurs 4"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-------for bitti-------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
        
    }
}
