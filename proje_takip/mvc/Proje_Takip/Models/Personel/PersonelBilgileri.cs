using Proje_Takip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Proje_Takip.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            //this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }

        [DisplayName("E Posta")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")] public string Eposta { get; set; } // Db Giriş Bilgileri Backend Adları        
        [DisplayName("Şifre")]// Display Fronted Adları

        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Sifre { get; set; } // Db Giriş Bilgileri Backend Adları
        [DisplayName("Yetki")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Yetki { get; set; } // Db Giriş Bilgileri Backend Adları
        [DisplayName("Ad Soyad")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string AdSoyad { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Tc No")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string TCNO { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Departman")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Departman { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Görev")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Gorev { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Açıklama")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string PozisyonAciklama { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Telefon No")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string TelNo { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Adres")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string Adres { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Medeni Hal")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string MedeniHal { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Yakınlık Derecesi")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string YakinBilgisi { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Yakın Tc")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string YakinTC { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Yakın Ad Soyad")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string YakinAdsoyad { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Yakın Telefon No")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string YakinTel { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("Doğum Tarihi")]// Display Fronted Adları

        public DateTime DogumTarihi { get; set; } // Db Giriş Bilgileri Backend Adları

        [DisplayName("İşe Giriş Tarihi")]// Display Fronted Adları

        public DateTime? IseGirisTarihi { get; set; } // Db Giriş Bilgileri Backend Adları

       // public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }
       public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }



    }
}