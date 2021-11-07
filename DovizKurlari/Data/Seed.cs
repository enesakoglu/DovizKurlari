using DovizKurlari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DovizKurlari.Data
{
    public class Seed
    {
        public static async Task SeedData(MyApplicationContext context)
        {
            var serbestKurlar = new List<SerbestKurlar>
            {
                new SerbestKurlar
                {
                    DovizKodu = 2, Doviz = "USD",  CaprazKur = 1.00000, DovizAlis = 8.42877, DovizSatis = 8.45467, EfektifAlis = 8.18877, EfektifSatis = 8.69467
                },
                new SerbestKurlar
                {
                    DovizKodu = 7, Doviz = "DKK",  CaprazKur = 6.31146, DovizAlis = 1.33547, DovizSatis = 1.34179, EfektifAlis = 1.30797, EfektifSatis = 1.36929
                },
                new SerbestKurlar
                {
                    DovizKodu = 10, Doviz = "SEK",  CaprazKur = 8.65919, DovizAlis = 0.97339, DovizSatis = 0.97967, EfektifAlis = 0.97089, EfektifSatis = 0.98217
                },
                new SerbestKurlar
                {
                    DovizKodu = 11, Doviz = "CHF",  CaprazKur = 0.92041, DovizAlis = 9.15761, DovizSatis = 9.21576, EfektifAlis = 8.18261, EfektifSatis = 10.19076
                },
                new SerbestKurlar
                {
                    DovizKodu = 13, Doviz = "JPY",  CaprazKur = 110.21025, DovizAlis = 7.64790, DovizSatis = 7.69350, EfektifAlis = 7.63790, EfektifSatis = 7.70350
                },
                new SerbestKurlar
                {
                    DovizKodu = 14, Doviz = "CAD",  CaprazKur = 1.26730, DovizAlis = 6.65096, DovizSatis = 6.68609, EfektifAlis = 6.63596, EfektifSatis = 6.70109
                },
                new SerbestKurlar
                {
                    DovizKodu = 16, Doviz = "NOK",  CaprazKur = 8.84530, DovizAlis = 0.95291, DovizSatis = 0.99422, EfektifAlis = 0.93291, EfektifSatis = 1.01422
                },
                new SerbestKurlar
                {
                    DovizKodu = 17, Doviz = "GBP", CaprazKur = 1.38161, DovizAlis = 11.64523, DovizSatis = 11.67729, EfektifAlis = 11.37023, EfektifSatis = 11.97729
                },
                new SerbestKurlar
                {
                    DovizKodu = 21, Doviz = "EUR", CaprazKur = 1.17854, DovizAlis = 9.93365, DovizSatis = 9.96600, EfektifAlis = 9.69615, EfektifSatis = 10.20350
                },
                new SerbestKurlar
                {
                    DovizKodu = 1, Doviz = "TL", CaprazKur = 8.44161, DovizAlis = 1.00000, DovizSatis = 1.00000, EfektifAlis = 1.00000, EfektifSatis = 1.00000
                },
                new SerbestKurlar
                {
                    DovizKodu = 51, Doviz = "XAU", CaprazKur = 57.13752, DovizAlis = 481.59900, DovizSatis = 485.29400, EfektifAlis = 433.59900, EfektifSatis = 534.04400
                },
                new SerbestKurlar
                {
                    DovizKodu = 52, Doviz = "XAG", CaprazKur = 1.00000, DovizAlis = 1.00000, DovizSatis = 1.00000, EfektifAlis = 1.00000, EfektifSatis = 1.00000
                }
            };

            var internetKurlari = new List<InternetKurlari>
            {
                new InternetKurlari
                {
                    DovizKodu = 2, Doviz = "USD",  CaprazKur = 1.00000, DovizAlis = 8.42374, DovizSatis = 8.45966
                },
                new InternetKurlari
                {
                    DovizKodu = 7, Doviz = "DKK",  CaprazKur = 6.30817, DovizAlis = 1.33537, DovizSatis = 1.34171
                },
                new InternetKurlari
                {
                    DovizKodu = 13, Doviz = "JPY",  CaprazKur = 110.29014, DovizAlis = 7.63780, DovizSatis = 7.70340
                },
                new InternetKurlari
                {
                    DovizKodu = 11, Doviz = "CHF",  CaprazKur = 0.92041, DovizAlis = 9.15761, DovizSatis = 9.21576
                },
                new InternetKurlari
                {
                    DovizKodu = 14, Doviz = "CAD", CaprazKur = 1.26475, DovizAlis = 6.66041, DovizSatis = 6.67549
                },
                new InternetKurlari
                {
                    DovizKodu = 16, Doviz = "NOK", CaprazKur = 8.84150, DovizAlis = 0.95275, DovizSatis = 0.99406
                },
                new InternetKurlari
                {
                    DovizKodu = 17, Doviz = "GBP", CaprazKur = 1.38175, DovizAlis = 11.63950, DovizSatis = 11.70661
                },
                new InternetKurlari
                {
                    DovizKodu = 21, Doviz = "EUR", CaprazKur = 1.17768, DovizAlis = 9.92048, DovizSatis = 9.97786
                },
                new InternetKurlari
                {
                    DovizKodu = 1, Doviz = "TL", CaprazKur = 1.00000, DovizAlis = 1.00000, DovizSatis = 1.00000
                },
                new InternetKurlari
                {
                    DovizKodu = 51, Doviz = "XAU", CaprazKur = 57.15644, DovizAlis = 481.47100, DovizSatis = 485.17200
                },
                new InternetKurlari
                {
                    DovizKodu = 52, Doviz = "XAG", CaprazKur = 1.00000, DovizAlis = 1.00000, DovizSatis = 1.00000
                }
            };

            var marbasPariteleri = new List<MarbasPariteleri>
            {
                new MarbasPariteleri
                {
                    PariteCinsi = "17   2   GBP-USD", AlisParitesi = 1.37632,  SatisParitesi = 1.38643
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "21   2   EUR-USD", AlisParitesi = 1.17696,  SatisParitesi = 1.18004
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   7   USD-DKK", AlisParitesi = 6.30713,  SatisParitesi = 6.31257
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   10   USD-SEK", AlisParitesi = 8.64350,  SatisParitesi = 8.65570
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   11   USD-CHF", AlisParitesi = 0.91479, SatisParitesi = 0.92491
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "21   11   EUR-CHF", AlisParitesi = 1.08304, SatisParitesi = 1.08518
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   13   USD-JPY", AlisParitesi = 110.00300, SatisParitesi = 110.21200
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "21   13   EUR-JPY", AlisParitesi = 129.51500, SatisParitesi = 130.02700
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "17   13   GBP-JPY", AlisParitesi = 152.00200, SatisParitesi = 152.21800
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   14   USD-CAD", AlisParitesi = 1.26548, SatisParitesi = 1.26762
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "21   16   EUR-NOK", AlisParitesi = 10.22196, SatisParitesi = 10.22733
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "2   16   USD-NOK", AlisParitesi = 8.67152, SatisParitesi = 8.67916
                },
                new MarbasPariteleri
                {
                    PariteCinsi = "21   17   EUR-GBP", AlisParitesi = 0.85210, SatisParitesi = 0.85421
                }
            };

            await context.SerbestKurlar.AddRangeAsync(serbestKurlar);
            await context.InternetKurlari.AddRangeAsync(internetKurlari);
            await context.MarbasPariteleri.AddRangeAsync(marbasPariteleri);


            await context.SaveChangesAsync();


        }
    }
}
