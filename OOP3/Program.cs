using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasıtKredi = new TasitKrediManager();
            IKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasıtKredi);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredi,tasıtKredi};

            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            basvuruManager.BasvuruYap(new EsnafKredisiManager(),
            new List<ILoggerService> { 
            new DatabaseLoggerService(),
            new SmsLoggerService()
            });
            Console.WriteLine("Loglar tanımlandı.");
        }
    }
}
