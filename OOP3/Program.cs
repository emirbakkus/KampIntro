using System.Collections.Generic;

namespace OOP3 
{ 
  internal class Program
 {
    static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager esnafKrediManager = new EsnafKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService smsLoggerService = new SmsLoggerService();

        List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerService };

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(konutKrediManager, loggerServices);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager, esnafKrediManager };
      

        basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        basvuruManager.LoglamaYap(loggerServices);




        }
    }
}