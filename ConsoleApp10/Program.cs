using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anasayfa üzerinde gösterilen ilanların başlıklarını yazdırabiliyorum. Fiyatları ilanın detay sayfasında olduğu için o linkleri bir dizide tutup tekrar döndürüp yazdırmam gerekiyor.
            //Yapamadığım yer ise hem ilanların href linkleri ve detayların href linklerini alamıyorum. Alabildiğim takdirde her ilanın yanında o ilana ait olan fiyatları yazdırabilirim.
            //Şu an için db bağlantısı kurmadım fakat html linklerini alabiyor olsaydım db first ile bir adet tablo ve anasayfadan aldığım her ilanın detay linkini ilanid, detaylink ve ilanfiyati olarak propertylere yazdırıp, konsola bastırabileciğimi düşünüyorum. Teşekkür ederim.


            HtmlWeb web = new HtmlWeb();
            Uri uri = new Uri("https://www.sahibinden.com");
            HtmlDocument document = web.Load(uri);
            var links = document.DocumentNode.SelectNodes("/html/body/div[5]/div[3]/div/div[3]/div[3]/ul").First().InnerText;
            Console.WriteLine(links);


            //List<string> links = new List<string>();
            //links.Add("https://www.sahibinden.com");
            //foreach (var item in links)
            //{
            //    HtmlWeb web = new HtmlWeb();
            //    HtmlDocument document = web.Load(item);
            //    var title = document.DocumentNode.SelectNodes("/html/body/div[5]/div[3]/div/div[3]/div[3]/ul").First().InnerHtml;
            //    Console.WriteLine(title);
            //}
            Console.ReadLine();
        }
    }
}
