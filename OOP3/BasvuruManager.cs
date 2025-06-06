﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            //
            
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); // Loglama işlemi
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();   
            }
        }
        public void LoglamaYap(List<ILoggerService> loggerServices)
        {
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); // Loglama işlemi
            }
        }
    }
}
