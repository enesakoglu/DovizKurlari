using DovizKurlari.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DovizKurlari.Data
{

    public class MyApplicationContext : DbContext
    {
        public MyApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SerbestKurlar> SerbestKurlar { get; set; }
        public DbSet<InternetKurlari> InternetKurlari { get; set; }
        public DbSet<MarbasPariteleri> MarbasPariteleri { get; set; }
    }
}
