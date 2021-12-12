using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot
{
    public static class Class1
    {
        public static void NewMethod()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("\nPiyasa verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.PiyasaCek.FinansPiyasaCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 2:
                    Console.WriteLine("\nÇapraz kur verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.CaprazKurlarCek.FinansCaprazKurCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 3:
                    Console.WriteLine("\nSerbest piyasa doviz kurları çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.SerbestPiyasaCek.FinansSerbetPiyasaCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 4:
                    Console.WriteLine("\nMerkez Bankası verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.MerkezBankasiCek.FinansMerkezBankasiCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 5:
                    Console.WriteLine("\nBanka gişe döviz verileri çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.BankaGiseCek.FinansBankGiseCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 6:
                    Console.WriteLine("\nKripto Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.KriptoCek.FinansKriptoCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                default:
                    Console.Write("Hatalı seçim yaptınız..");
                    break;
            }
        }
    }
}
