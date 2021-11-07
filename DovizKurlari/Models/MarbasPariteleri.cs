using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DovizKurlari.Models
{
    public class MarbasPariteleri
    {
        public int Id { get; set; }

        [Display(Name = "Parite Cinsi", AutoGenerateFilter = false)]
        public string PariteCinsi { get; set; }

        [Display(Name = "Alış Paritesi", AutoGenerateFilter = false)]
        public double AlisParitesi { get; set; }

        [Display(Name = "Satış Paritesi", AutoGenerateFilter = false)]
        public double SatisParitesi { get; set; }
    }
}


