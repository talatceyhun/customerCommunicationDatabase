using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DboDubelsan
{
    public partial class Mail : Form
    {
        sqlbaglanti baglan = new sqlbaglanti();
        public Mail()
        {
            InitializeComponent();
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            kisiListesi();
        }
        void gonderMail (List<string> liste, string konu, string metin)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            string mail = "";
            string sifre = "";
            SqlCommand komut = new SqlCommand("Select Email, Sifre From Mail",baglan.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                mail = reader[0].ToString();
                sifre = reader[1].ToString();

            }
            istemci.Credentials = new System.Net.NetworkCredential(mail,sifre);
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.From = new MailAddress(mail);
            mesajim.Subject = konu;
            mesajim.Body = metin;
            foreach (string item in liste)
            {
                mesajim.Bcc.Add(item);
                //mesajim.To.Add(item);
                istemci.Send(mesajim);
            }



        }

        

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {
            
            grupListesi();
        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }
        void kisiListesi()
        {
            SqlCommand komut = new SqlCommand("Select Firma_Adi From Musteriler Where Musteriler.mail <> ''", baglan.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                firmaText.Properties.Items.Add(reader[0].ToString());
            }
        }
        void grupListesi()
        {
            grupSec.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select Grup_Adı From Gruplar", baglan.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                grupSec.Properties.Items.Add(reader[0].ToString());

            }

        }
        private void girisButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Drop Table Mail; " +
                "Create Table Mail(" +
                "Email varchar(50) Not Null," +
                "Sifre varchar(20) Not Null )", baglan.baglanti());
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Insert Into Mail (Email, Sifre)" +
                "Values (@p1,@p2)", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1", mailText.Text);
            komut2.Parameters.AddWithValue("@p2", sifreText.Text);
            komut2.ExecuteNonQuery();
            baglan.baglanti().Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mailGonderKisi_Click(object sender, EventArgs e)
        {
            List<string> kisi = new List<string>();
            string mail = "";
            SqlCommand komut = new SqlCommand("Select mail From Musteriler Where Firma_Adi = @p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", firmaText.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                mail = reader[0].ToString();
            }
            kisi.Add(mail);
            string konu = konuTextFirma.Text;
            string metin = mailTextFirma.Text;
            gonderMail(kisi, konu, metin);
            baglan.baglanti().Close();
        }

        private void mailGonderGrup_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            int grupID = 0;
            SqlCommand komut = new SqlCommand("Select Grup_ID From Gruplar Where Grup_Adı = @p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",grupSec.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                grupID =Int32.Parse(reader[0].ToString());
            }
            SqlCommand komut2 = new SqlCommand("Select mail From Musteriler Where Grup_ID = @p2", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p2", grupID);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                kisiler.Add(dr[0].ToString());
            }
            string konu = konuTextGrup.Text;
            string metin = mailTextGrup.Text;
            gonderMail(kisiler, konu, metin);
            baglan.baglanti().Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mailGonderTarih_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateFormatla(baslangicTarih.Text));
            List<string> kisiler = new List<string>();
            SqlCommand komut = new SqlCommand("Select mail From Musteriler Where Musteri_Tarih between @p1 and @p2 and Musteriler.mail <> ''", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",dateFormatla(baslangicTarih.Text));
            komut.Parameters.AddWithValue("@p2", dateFormatla(bitisTarih.Text));
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                kisiler.Add(reader[0].ToString());

            }
            string konu = konuTextTarih.Text;
            string metin = mailTextGrup.Text;
            gonderMail(kisiler, konu, metin);
            baglan.baglanti().Close();
        }
        string dateFormatla(string date)
        {
            string[] tarih = new string[3];
            tarih = date.Split('.');


            return tarih[2]+"-"+tarih[1]+"-"+tarih[0];
        }

        private void mailGonderHerkes_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            SqlCommand komut = new SqlCommand("Select mail From Musteriler Where mail <> ''", baglan.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                kisiler.Add(reader[0].ToString());
            }
            string konu = konuHerkes.Text;
            string metin = mailTextHerkes.Text;
            gonderMail(kisiler, konu, metin);
        }
    }
}
