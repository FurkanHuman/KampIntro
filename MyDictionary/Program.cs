using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> urun = new Dictionary<int, string>();
            urun.Add(123,"Süt");
            urun.Add(888, "Dana Antrikot");
            urun.Add(0, "Ekmek");
            urun.Add(777, "Prevazatif");
            urun.Add(567, "Çikolata Sosu");
        }
    }
}
