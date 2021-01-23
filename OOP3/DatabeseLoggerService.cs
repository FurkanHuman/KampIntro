using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabeseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
