using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prpje_Takip
{
    public partial class PersonelBilgileri : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void listele()
        {
            con = new SqlConnection(" server= . ; initial catalog= PROJETAKIPDB; integrated security = sspi ");
            string kayit = "select * from PersonelBilgileris";
            da = new SqlDataAdapter(kayit, con);

            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView1.DataSource = tablo;
        }

        public PersonelBilgileri()
        {
            InitializeComponent();
        }
        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
           listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(" server= . ; initial catalog= PROJETAKIPDB; integrated security = sspi ");
            string kayit = "insert into PersonelBilgileris values @PersonelBilgileriId, @Eposta, @Sifre, @Yetki, @AdSoyad, @TCNO, @Departman, @Gorev, @PozisyonAciklama, @TelNo, @Adres, @MedeniHal, @YakinBilgisi, @YakinTC, @YakinAdsoyad, @YakinTel, @DogumTarihi, @IseGirisTarihi)";
            cmd = new SqlCommand(kayit, con);            
            cmd.Parameters.AddWithValue("@PersonelBilgileriId", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Eposta", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@Yetki", textBox4.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@TCNO", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Departman", textBox11.Text);
            cmd.Parameters.AddWithValue("@Gorev", textBox10.Text);
            cmd.Parameters.AddWithValue("@PozisyonAciklama", textBox8.Text);
            cmd.Parameters.AddWithValue("@TelNo", maskedTextBox3.Text);
            cmd.Parameters.AddWithValue("@Adres", textBox6.Text);
            cmd.Parameters.AddWithValue("@MedeniHal", textBox5.Text);
            cmd.Parameters.AddWithValue("@YakinBilgisi", textBox15.Text);
            cmd.Parameters.AddWithValue("@YakinTC", maskedTextBox4.Text);
            cmd.Parameters.AddWithValue("@YakinAdsoyad", textBox13.Text);
            cmd.Parameters.AddWithValue("YakinTel", maskedTextBox5.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", maskedTextBox6.Text);
            cmd.Parameters.AddWithValue("@IseGirisTarihi", maskedTextBox7.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(" server= . ; initial catalog= PROJETAKIPDB; integrated security = sspi ");
            string komut = " update PersonelBilgileris set Eposta=@Eposta, Sifre=@Sifre, Yetki=@Yetki, AdSoyad=@AdSoyad, TCNO=@TCNO, Departman=@Departman, Gorev=@Gorev, PozisyonAciklama=@PozisyonAciklama, TelNo=@TelNo, Adres=@Adres, MedeniHal=@MedeniHal, YakinBilgisi=@YakinBilgisi, YakinTC=@YakinTC, YakinAdsoyad=@YakinAdsoyad, YakinTel=@YakinTel, DogumTarihi=@DogumTarihi, IseGirisTarihi=@IseGirisTarihi where PersonelBilgileriId = @PersonelBilgileriId";
            cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@PersonelBilgileriId", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Eposta", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@Yetki", textBox4.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@TCNO", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Departman", textBox11.Text);
            cmd.Parameters.AddWithValue("@Gorev", textBox10.Text);
            cmd.Parameters.AddWithValue("@PozisyonAciklama", textBox8.Text);
            cmd.Parameters.AddWithValue("@TelNo", maskedTextBox3.Text);
            cmd.Parameters.AddWithValue("@Adres", textBox6.Text);
            cmd.Parameters.AddWithValue("@MedeniHal", textBox5.Text);
            cmd.Parameters.AddWithValue("@YakinBilgisi", textBox15.Text);
            cmd.Parameters.AddWithValue("@YakinTC", maskedTextBox4.Text);
            cmd.Parameters.AddWithValue("@YakinAdsoyad", textBox13.Text);
            cmd.Parameters.AddWithValue("YakinTel", maskedTextBox5.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", maskedTextBox6.Text);
            cmd.Parameters.AddWithValue("@IseGirisTarihi", maskedTextBox7.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(" server= . ; initial catalog= PROJETAKIPDB; integrated security = sspi ");
            string kayit = " delete from PersonelBilgileris where PersonelBilgileriId = @PersonelBilgileriId ";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@PersonelBilgilerId",int.Parse(textBox2.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            maskedTextBox5.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            maskedTextBox6.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            maskedTextBox7.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
        }
    }
}
