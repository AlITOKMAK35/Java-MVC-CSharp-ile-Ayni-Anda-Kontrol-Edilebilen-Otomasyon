using Proje_Takip.Models.Musteri;
using Proje_Takip.Models.MusteriTakip;
using Proje_Takip.Models.Personel;
using Proje_Takip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proje_Takip.Models.DataContext
{
    public class ProjeTakipDBContext : DbContext
    {

        public ProjeTakipDBContext() : base ("ProjeTakipDB")
        { 
        }

        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }

        public DbSet<MusteriBilgileri> MusteriBilgileris { get; set; }
        public DbSet<MusteriProjeleri> MusteriProjeleris { get; set; }
    }
}