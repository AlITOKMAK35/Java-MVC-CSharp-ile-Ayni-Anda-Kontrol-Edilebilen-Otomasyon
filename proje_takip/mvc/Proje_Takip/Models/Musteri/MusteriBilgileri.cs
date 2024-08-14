using Proje_Takip.Models.MusteriTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Proje_Takip.Models.Musteri
{
    public class MusteriBilgileri
    {
        public MusteriBilgileri()
        {
            this.MusteriProjeleris = new HashSet<MusteriProjeleri>();
        }
        [Key]

        public int MusteriBilgileriId { get; set; }
        [DisplayName("Ad")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Ad { get; set; }
        [DisplayName("Soyad")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Soyad { get; set; }
        [DisplayName("E Posta")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Mail { get; set; }
        [DisplayName("Telefon Numarası")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string TelNo { get; set; }
        [DisplayName("Adres")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Adres { get; set; }
        [DisplayName("Cinsiyet")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Cinsiyet { get; set; }

        public ICollection<MusteriProjeleri>MusteriProjeleris { get; set; }
    }
}