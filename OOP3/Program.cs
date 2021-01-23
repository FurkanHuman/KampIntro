using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyac = new İhtiyacKrediManager();
            IKrediManager tasit = new TasitKrediManager();
            IKrediManager konut = new KonutKrediManager();

            ILoggerService dataloggerService = new DatabeseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konut,fileloggerService);        
 
            List<IKrediManager> krediManagers = new List<IKrediManager>()
            {ihtiyac,tasit};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
        }
    }
}
