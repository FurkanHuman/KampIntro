﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyabakır karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("-----------Metotlar-----------");
            // İstance 
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Sarı", 15,100);
            sepetManager.Ekle2("Elma", "Kırmızı", 5,1000);
            sepetManager.Ekle2("Avakado", "Yeşil", 20, 10);
        }
    }
}