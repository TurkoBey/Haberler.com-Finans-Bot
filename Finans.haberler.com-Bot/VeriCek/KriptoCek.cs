using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot.VeriCek
{
    class KriptoCek
    {
        public static void FinansKriptoCek()
        {
            try
            {
                var site = "https://www.haberler.com/finans/kripto-paralar/";

                List<Doviz> DovizListesi = new List<Doviz>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var DovizXpath = "//div[@class='hbTableContent piyasa']";
                var DovizX = document.DocumentNode.SelectNodes(DovizXpath);

                foreach (var Doviz in DovizX)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        string KriptoPara = Doviz.SelectSingleNode("//div[1]/div[1]/table/tbody/tr[" + i + "]/td[1]").InnerText;
                        string KriptoPiyasaDegeri = Doviz.SelectSingleNode("//div[1]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]").InnerText;
                        string KriptoHacim = Doviz.SelectSingleNode("//div[1]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[4]").InnerText;
                        string KriptoArz = Doviz.SelectSingleNode("//div[1]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[5]").InnerText;
                        string KriptoFark = Doviz.SelectSingleNode("//div[1]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[6]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            KriptoPara = KriptoPara,
                            KriptoPiyasaDegeri = KriptoPiyasaDegeri,
                            KriptoHacim = KriptoHacim,
                            KriptoArz = KriptoArz,
                            KriptoFark = KriptoFark
                        });
                    }
                }
                Console.WriteLine("======================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Kripto Para        :: {Doviz.KriptoPara}");
                    Console.WriteLine($"Kripto Piy. Değeri :: {Doviz.KriptoPiyasaDegeri}");
                    Console.WriteLine($"Kripto Hacim       :: {Doviz.KriptoHacim}");
                    Console.WriteLine($"Kripto Arz         :: {Doviz.KriptoArz}");
                    Console.WriteLine($"Kripto Fark        :: {Doviz.KriptoFark}");
                    Console.WriteLine("=============================");
                }
            }
            catch (Exception mesaj)
            {
                Console.WriteLine(">>" + mesaj.Message);
            }
        }
    }
}
