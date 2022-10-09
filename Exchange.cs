using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photovoltaics;

namespace Photovoltaics {
     public static class Exchange {
        public static double burza() {
            //cena z burzy
            HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = website.Load("https://www.kurzy.cz/komodity/cena-elektriny-graf-vyvoje-ceny/1MWh-czk-3-roky");
            var datalist = document.DocumentNode.SelectNodes("//td[@class='rght']").ToList();
            //foreach (var content in datalist) {
            //    Console.WriteLine(content.InnerText);
            //}

            string withoutSpaces = String.Concat(datalist[1].InnerText.Where(c => !Char.IsWhiteSpace(c)));
            double transfer = Convert.ToDouble(withoutSpaces);
            double kwh = transfer / 1000;
            return kwh;
        }
    }
}
