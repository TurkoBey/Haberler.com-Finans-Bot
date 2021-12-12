using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "haberler.com/finans/ Botu";

            Console.WriteLine(
                "\n==========================================================\n"+
                "haberler.com/finans/ Döviz & Altın Kuru Çeken Bot" +
                "\n==========================================================\n");

            Console.WriteLine(
                "[ 1 ] ==> Piyasa ( Doviz & Bist & Altın )" + "\n" +
                "[ 2 ] ==> Capraz Kurlar" + "\n" +
                "[ 3 ] ==> Serbest Piyasa Kurları" + "\n" +
                "[ 4 ] ==> Merkez Bankası Kurları" + "\n" +
                "[ 5 ] ==> Banka Gişe Kurları" + "\n" +
                "[ 6 ] ==> Kripto Para" +
                "\n\n==========================================================\n");

            Console.Write("Seçim yapınız : ");

            try
            {
                Class1.NewMethod();
            }
            catch (Exception)
            {
                Console.Write("Sadece sayı değeri giriniz..");
            }
            finally
            {
                Console.Write("\n\nSeçim yapınız : ");
                Class1.NewMethod();
            }

            Console.ReadLine();
        }
        
    }
}
