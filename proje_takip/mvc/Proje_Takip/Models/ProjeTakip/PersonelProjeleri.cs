using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Proje_Takip.Models.Personel;


namespace Proje_Takip.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri()
        {
            //this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
        [Key]

        public int PersonelProjeleriId { get; set; }

        [DisplayName("Proje Başlığı")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string ProjeBaslik { get; set; }

        [DisplayName("Proje Açıklama")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string ProjeAciklama { get; set; }

        [DisplayName("Oluşturulma Tarihi")]// Display Fronted Adları

        public DateTime OlusturulmaTarihi { get; set; }

        [DisplayName("Öncelik Durumu")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string OncelikDurumu { get; set; }

        [DisplayName("Tamamlanma Oranı")]// Display Fronted Adları
        [StringLength(50, ErrorMessage = "Maximum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string TamamlanmaOrani { get; set; }

        [DisplayName("Tamamlanma Tarihi")]// Display Fronted Adları

        public DateTime? TamamlanmaTarihi { get; set; }

        [DisplayName("Tamamlanma Durumu")]// Display Fronted Adları

        public bool TamamlanmaDurumu { get; set; }

       // public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }

        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }

    }
}
