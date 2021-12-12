using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot.VeriCek
{
    public static class SerbestPiyasaCek
    {
        public static void FinansSerbetPiyasaCek()
        {
            try
            {
                var site = "https://www.haberler.com/finans/doviz/";

                List<Doviz> DovizListesi = new List<Doviz>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var DovizXpath = "//div[@class='hbTableContent piyasa']";
                var DovizX = document.DocumentNode.SelectNodes(DovizXpath);

                foreach (var Doviz in DovizX)
                {
                    for (int i = 1; i <= 11; i++)
                    {
                        string DovizCinsi = Doviz.SelectSingleNode("//div[1]/table[1]/tbody[1]/tr[" + i + "]/td[1]/a[1]").InnerText;
                        string DovizAlis = Doviz.SelectSingleNode("//div[1]/div/div/table/tbody/tr[" + i + "]/td[3]").InnerText;
                        string DovizSatis = Doviz.SelectSingleNode("//div[1]/div/div/table/tbody/tr[" + i + "]/td[4]").InnerText;
                        string DovizDegisim = Doviz.SelectSingleNode("//div[1]/div/div/table/tbody/tr[" + i + "]/td[5]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            DovizAD = DovizCinsi,
                            DovizAlis = DovizAlis,
                            DovizSatis = DovizSatis,
                            DovizDegisim= DovizDegisim
                        });
                    }
                }
                Console.WriteLine("======================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Döviz Cinsi   :: {Doviz.DovizAD}");
                    Console.WriteLine($"Döviz Alış    :: {Doviz.DovizAlis}" + " TL");
                    Console.WriteLine($"Döviz Satış   :: {Doviz.DovizSatis}" + " TL");
                    Console.WriteLine($"Döviz Değişim :: {Doviz.DovizDegisim}");
                    Console.WriteLine("======================");
                }
            }
            catch (Exception mesaj)
            {
                Console.WriteLine(">>" + mesaj.Message);
            }
        }
    }
}
