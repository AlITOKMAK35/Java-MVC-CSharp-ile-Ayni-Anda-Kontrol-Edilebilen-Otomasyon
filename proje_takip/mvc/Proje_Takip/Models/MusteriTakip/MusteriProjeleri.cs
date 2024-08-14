using Proje_Takip.Models.Musteri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;


namespace Proje_Takip.Models.MusteriTakip
{
    public class MusteriProjeleri
    {
        public MusteriProjeleri() 
        {
            this.MusteriBilgileris = new HashSet<MusteriBilgileri>();
        }
        [Key] 

        public int MusteriProjeleriId { get; set; }
        [DisplayName("Firma Adı")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string firmaadi { get; set; }
        [DisplayName("Ünvan")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string unvan { get; set; }
        [DisplayName("Öneri Formu")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string sikayetistek { get; set; }
        [DisplayName("Açıklama")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string aciklama { get; set; }
        [DisplayName("Firma Projesi")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string firmaprojesi { get; set; }
        [DisplayName("Proje Numarası")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string projenumarası { get; set; }
        [DisplayName("Proje Adı")]
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string projeadi { get; set; }
        [DisplayName("Randevu Tarihi")]
        public DateTime randevutarihi { get; set; }
        [DisplayName("Uygulama Tarihi")]
        public DateTime uygulamatarihi { get; set; }
        [DisplayName("Teslim Tarihi")]
        public DateTime teslimtarihi { get; set; }  

        public ICollection<MusteriBilgileri>MusteriBilgileris { get; set; }
    }


}