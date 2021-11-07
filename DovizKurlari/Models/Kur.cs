using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DovizKurlari.Models
{
    public class Kur
    {
        public int Id { get; set; }

        [Display(Name = "Doviz Kodu", AutoGenerateFilter = false)]
        public int DovizKodu { get; set; }

        [Display(Name = "Doviz", AutoGenerateFilter = false)]
        public string Doviz { get; set; }

        [Display(Name = "Çapraz Kur", AutoGenerateFilter = false)]
        public double CaprazKur { get; set; }

        [Display(Name = "Döviz Alış", AutoGenerateFilter = false)]
        public double DovizAlis { get; set; }

        [Display(Name = "Doviz Satış", AutoGenerateFilter = false)]
        public double DovizSatis { get; set; }
    }
}

