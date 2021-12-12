using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot.VeriCek
{
    public static class PiyasaCek
    {
        public static void FinansPiyasaCek()
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
                    for (int i = 1; i <= 10; i++)
                    {
                        string DovizCinsi = Doviz.SelectSingleNode("//div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/a").InnerText;
                        string DovizSon = Doviz.SelectSingleNode("//div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]").InnerText;
                        string DovizDegisim = Doviz.SelectSingleNode("//div[1]/div/div/table/tbody/tr[" + i + "]/td[5]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            DovizAD = DovizCinsi,
                            DovizSon = DovizSon,
                            DovizDegisim = DovizDegisim
                        });
                    }
                }
                Console.WriteLine("======================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Döviz Cinsi   :: {Doviz.DovizAD}");
                    Console.WriteLine($"Döviz Alış    :: {Doviz.DovizSon}" + " TL");
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
