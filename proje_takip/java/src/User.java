/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author ahmet
 */
public class User {
    private int PersonelProjeleriId;
    private String ProjeBaslik, ProjeAciklama, OlusturulmaTarihi, OncelikDurumu, TamamlanmaOrani, TamamlanmaTarihi, TamamlanmaDurumu;
    
    public User(int PersonelProjeleriId, String ProjeBaslik, String ProjeAciklama, String OlusturulmaTarihi, String OncelikDurumu , String TamamlanmaOrani , String TamamlanmaTarihi, String TamamlanmaDurumu)
    {
      this.PersonelProjeleriId=PersonelProjeleriId;
      this.ProjeBaslik=ProjeBaslik;
      this.ProjeAciklama=ProjeAciklama;
      this.OlusturulmaTarihi=OlusturulmaTarihi;
      this.OncelikDurumu=OncelikDurumu;
      this.TamamlanmaOrani=TamamlanmaOrani;
      this.TamamlanmaTarihi=TamamlanmaTarihi;
      this.TamamlanmaDurumu=TamamlanmaDurumu;
    }
    public int getPersonelProjeleriId(){
        return PersonelProjeleriId;
    }
    public String getProjeBaslik(){
        return ProjeBaslik;
    }
    public String getProjeAciklama(){
        return ProjeAciklama;
    }
    public String getOlusturulmaTarihi(){
        return OlusturulmaTarihi;
    }
    public String getOncelikDurumu(){
        return OncelikDurumu;
    }
    public String getTamamlanmaOrani(){
        return TamamlanmaOrani;
    }
    public String getTamamlanmaTarihi(){
        return TamamlanmaTarihi;
    }
    public String getTamamlanmaDurumu(){
        return TamamlanmaDurumu;
    }
}
