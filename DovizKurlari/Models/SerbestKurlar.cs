using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DovizKurlari.Models
{
    public class SerbestKurlar : Kur
    {

        [Display(Name = "Efektif Alış", AutoGenerateFilter = false)]
        public double EfektifAlis { get; set; }

        [Display(Name = "Efektif Satış", AutoGenerateFilter = false)]
        public double EfektifSatis { get; set; }
    }
}
