using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans.haberler.com_Bot.VeriCek
{
    public static class CaprazKurlarCek
    {
        public static void FinansCaprazKurCek()
        {
            try
            {
                var site = "https://www.haberler.com/finans/doviz/capraz-kurlar/";

                List<Doviz> DovizListesi = new List<Doviz>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var DovizXpath = "//div[@class='hbTableContent piyasa']";
                var DovizX = document.DocumentNode.SelectNodes(DovizXpath);

                foreach (var Doviz in DovizX)
                {
                    for (int i = 1; i <= 21; i++)
                    {
                        string DovizCinsi = Doviz.SelectSingleNode("//div[1]/div[3]/div[3]/div/div[1]/div/div/table/tbody/tr[" + i + "]/td[1]").InnerText;
                        string DovizAlis = Doviz.SelectSingleNode("//div[1]/div[3]/div[3]/div/div[1]/div/div/table/tbody/tr[" + i + "]/td[3]").InnerText;
                        string DovizSatis = Doviz.SelectSingleNode("//div[1]/div[3]/div[3]/div/div[1]/div/div/table/tbody/tr[" + i + "]/td[4]").InnerText;
                        string DovizDusuk = Doviz.SelectSingleNode("//div[1]/div[3]/div[3]/div/div[1]/div/div/table/tbody/tr[" + i + "]/td[5]").InnerText;
                        string DovizYuksek = Doviz.SelectSingleNode("//div[1]/div[3]/div[3]/div/div[1]/div/div/table/tbody/tr[" + i + "]/td[6]").InnerText;
                        string DovizDegisim = Doviz.SelectSingleNode("//div[1]/div/div/table/tbody/tr[" + i + "]/td[5]").InnerText;

                        DovizListesi.Add(new Doviz()
                        {
                            DovizAD = DovizCinsi,
                            DovizAlis = DovizAlis,
                            DovizSatis = DovizSatis,
                            DovizDusuk = DovizDusuk,
                            DovizYuksek = DovizYuksek,
                            DovizDegisim = DovizDegisim
                        });
                    }
                }
                Console.WriteLine("======================");
                foreach (var Doviz in DovizListesi)
                {
                    Console.WriteLine($"Döviz Cinsi        :: {Doviz.DovizAD}");
                    Console.WriteLine($"Döviz Alış         :: {Doviz.DovizAlis}");
                    Console.WriteLine($"Döviz Satış        :: {Doviz.DovizSatis}");
                    Console.WriteLine($"Döviz En Düşük     :: {Doviz.DovizDusuk}");
                    Console.WriteLine($"Döviz En Yüksek    :: {Doviz.DovizYuksek}");
                    Console.WriteLine($"Döviz Değişim      :: {Doviz.DovizDegisim}");
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
