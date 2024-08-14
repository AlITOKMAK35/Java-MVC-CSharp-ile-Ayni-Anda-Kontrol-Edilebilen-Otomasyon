/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author ahmet
 */
public class User1 {
    private int PersonelBilgileriId;
    private String Eposta, Sifre, Yetki, AdSoyad, TCNO, Departman, Gorev, PozisyonAciklama, TelNo, Adres, MedeniHal, YakinBilgisi, YakinTC, YakinAdsoyad, YakinTel, DogumTarihi, IseGirisTarihi;
    
    public User1(int PersonelBilgileriId, String Eposta, String Sifre, String Yetki, String AdSoyad , String TCNO , String Departman, String Gorev , String PozisyonAciklama, String TelNo, String Adres, String MedeniHal, String YakinBilgisi, String YakinTC, String YakinAdsoyad, String YakinTel, String DogumTarihi, String IseGirisTarihi)
    {
      this.PersonelBilgileriId=PersonelBilgileriId;
      this.Eposta=Eposta;
      this.Sifre=Sifre;
      this.Yetki=Yetki;
      this.AdSoyad=AdSoyad;
      this.TCNO=TCNO;
      this.Departman=Departman;
      this.Gorev=Gorev;
      this.PozisyonAciklama=PozisyonAciklama;
      this.TelNo=TelNo;
      this.Adres=Adres;
      this.MedeniHal=MedeniHal;
      this.YakinBilgisi=YakinBilgisi;
      this.YakinTC=YakinTC;
      this.YakinAdsoyad=YakinAdsoyad;
      this.YakinTel=YakinTel;
      this.DogumTarihi=DogumTarihi;
      this.IseGirisTarihi=IseGirisTarihi;
      
    }
    public int getPersonelBilgileriId(){
        return PersonelBilgileriId;
    }
    public String getEposta(){
        return Eposta;
    }
    public String getSifre(){
        return Sifre;
    }
    public String getYetki(){
        return Yetki;
    }
    public String getAdSoyad(){
        return AdSoyad;
    }
    public String getTCNO(){
        return TCNO;
    }
    public String getDepartman(){
        return Departman;
    }
    public String getGorev(){
        return Gorev;
    }
    public String getPozisyonAciklama(){
        return PozisyonAciklama;        
    }
    public String getTelNo(){
        return TelNo;
    }
    public String getAdres(){
        return Adres;
    }
    public String getMedeniHal(){
        return MedeniHal;
    }
    public String getYakinBilgisi(){
        return YakinBilgisi;
    }
    public String getYakinTC(){
        return YakinTC;
    }
    public String getYakinAdsoyad(){
        return YakinAdsoyad;
    }
    public String getYakinTel(){
        return YakinTel;
    }
    public String getDogumTarihi(){
        return DogumTarihi;
    }
    public String getIseGirisTarihi(){
        return IseGirisTarihi;
    }
}
