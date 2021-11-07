using DovizKurlari.Data;
using DovizKurlari.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace DovizKurlari.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyApplicationContext _context;
        public HomeController(MyApplicationContext context)
        {
            this._context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<SerbestKurlar> dovizlers = null;
            dovizlers = await _context.SerbestKurlar.ToListAsync();

            return View(dovizlers);
        }

        public List<WebsiteDovizler> getCurrencyFromWebsite()
        {
            XmlDocument xml = new XmlDocument(); // yeni bir XML dökümü oluşturuyoruz.
            xml.Load("http://www.tcmb.gov.tr/kurlar/today.xml"); // bağlantı kuruyoruz.
            var Tarih_Date_Nodes = xml.SelectSingleNode("//Tarih_Date"); // Count değerini olmak için ana boğumu seçiyoruz.
            var CurrencyNodes = Tarih_Date_Nodes.SelectNodes("//Currency"); // ana boğum altındaki kur boğumunu seçiyoruz.
            int CurrencyLength = CurrencyNodes.Count; // toplam kur boğumu sayısını elde ediyor ve for döngüsünde kullanıyoruz.

            List<WebsiteDovizler> dovizler = new List<WebsiteDovizler>(); // Aşağıda oluşturduğum public class ile bir List oluşturuyoruz.
            for (int i = 0; i < CurrencyLength; i++) // for u çalıştırıyoruz.
            {
                var cn = CurrencyNodes[i]; // kur boğumunu alıyoruz.
                // Listeye kur bilgirini ekliyoruz.
                dovizler.Add(new WebsiteDovizler
                {
                    Kod = cn.Attributes["Kod"].Value,
                    CrossOrder = cn.Attributes["CrossOrder"].Value,
                    CurrencyCode = cn.Attributes["CurrencyCode"].Value,
                    Unit = cn.ChildNodes[0].InnerXml,
                    Isim = cn.ChildNodes[1].InnerXml,
                    CurrencyName = cn.ChildNodes[2].InnerXml,
                    ForexBuying = cn.ChildNodes[3].InnerXml,
                    ForexSelling = cn.ChildNodes[4].InnerXml,
                    BanknoteBuying = cn.ChildNodes[5].InnerXml,
                    BanknoteSelling = cn.ChildNodes[6].InnerXml,
                    CrossRateOther = cn.ChildNodes[8].InnerXml,
                    CrossRateUSD = cn.ChildNodes[7].InnerXml,
                });

            }
            return dovizler;
        }

       
    }
}