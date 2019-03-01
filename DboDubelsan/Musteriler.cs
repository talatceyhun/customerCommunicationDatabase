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

namespace DboDubelsan
{
    public partial class Musteriler : Form
    {
        private int musteriID;
        private string firmaAdi;
        private string yetkiliAd;
        private string kayitTarihi;
        private string il;
        private string ilce;
        private string adresLine;
        private string telefon1;
        private string telefon2;
        private string mail;
        private int grupID;
        private string musteriNot;



        sqlbaglanti baglan = new sqlbaglanti();
        //SqlConnection connection = baglan.baglanti();

        public int MusteriID { get => musteriID; set => musteriID = value; }
        public string FirmaAdi { get => firmaAdi; set => firmaAdi = value; }
        public string YetkiliAd { get => yetkiliAd; set => yetkiliAd = value; }
        public string KayitTarihi { get => kayitTarihi; set => kayitTarihi = value; }
        public string Il { get => il; set => il = value; }
        public string Ilce { get => ilce; set => ilce = value; }
        public string AdresLine { get => adresLine; set => adresLine = value; }
        public string Telefon1 { get => telefon1; set => telefon1 = value; }
        public string Telefon2 { get => telefon2; set => telefon2 = value; }
        public string Mail { get => mail; set => mail = value; }
        public int GrupID { get => grupID; set => grupID = value; }
        public string MusteriNot { get => musteriNot; set => musteriNot = value; }

        public Musteriler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notLabel_Click(object sender, EventArgs e)
        {

        }

        private void veriTablosu_Click(object sender, EventArgs e)
        {

        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Musteri_ID as ID, Firma_Adi as FirmaAdı, Yetkili_Ad as YetkiliAdı," +
                " Musteri_Tarih as KayıtTarihi, il, telefon1 as Telefon, mail as Mail From Musteriler", baglan.baglanti());
            da.Fill(dt);
            veriTablosu.DataSource = dt;
            baglan.baglanti().Close();
        }
        void temizle()
        {
            FirmaEditText.Text = "";
            YetkiliTextEdit.Text = "";
            ilEdit.Text = "";
            ilceEdit.Text = "";
            adresEditText.Text = "";
            telEdit.Text = "";
            telEdit2.Text = "";
            mailText.Text = "";
            grupEdit.Text = "";
            notlarText.Text = "";
        }

        void sehirListesi()
        {
            SqlCommand sqlkomut = new SqlCommand("Select sehir From iller", baglan.baglanti());
            SqlDataReader dr = sqlkomut.ExecuteReader();
            while (dr.Read())
            {
                ilEdit.Properties.Items.Add(dr[0]);
            }
            baglan.baglanti().Close();
        }

        public void grupListesi()
        {
            grupEdit.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select Grup_Adı From Gruplar", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                grupEdit.Properties.Items.Add(dr[0]);
            }
            baglan.baglanti().Close();
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            grupListesi();
            temizle();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            this.FirmaAdi = FirmaEditText.Text;
            this.YetkiliAd = YetkiliTextEdit.Text;
            this.KayitTarihi = tarihString();
            this.Il = ilEdit.Text;
            this.Ilce = ilceEdit.Text;
            this.AdresLine = adresEditText.Text;
            this.Telefon1 = telEdit.Text;
            this.Telefon2 = telEdit2.Text;
            this.Mail = mailText.Text;
            this.MusteriNot = notlarText.Text;
            SqlCommand komut = new SqlCommand("Insert Into Musteriler(Firma_Adi, Yetkili_Ad," +
                " Musteri_Tarih, il, ilce, adres_line, telefon1, telefon2, mail," +
                " Musteri_Not, Grup_ID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", FirmaAdi);
            komut.Parameters.AddWithValue("@p2", YetkiliAd);
            komut.Parameters.AddWithValue("@p3", KayitTarihi);
            komut.Parameters.AddWithValue("@p4", Il);
            komut.Parameters.AddWithValue("@p5", Ilce);
            komut.Parameters.AddWithValue("@p6", AdresLine);
            komut.Parameters.AddWithValue("@p7", Telefon1);
            komut.Parameters.AddWithValue("@p8", Telefon2);
            komut.Parameters.AddWithValue("@p9", Mail);
            komut.Parameters.AddWithValue("@p10", MusteriNot);
            komut.Parameters.AddWithValue("@p11", GrupID);
            komut.ExecuteNonQuery();
            listele();
            baglan.baglanti().Close();

            MessageBox.Show("Müşteri eklendi.");
            temizle();


        }
        string tarihString()
        {
            DateTime date = DateTime.Today;
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            string kayitDate = (year.ToString() + "-" + month.ToString() + "-" + day.ToString());
            return kayitDate;
        }

        private void ilEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceEdit.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce From ilceler Where sehir = @p1",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ilEdit.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilceEdit.Properties.Items.Add(dr[0]);
            }
            baglan.baglanti().Close();
        }

        private void grupEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Grup_ID From Gruplar Where Grup_Adı=@p1",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", grupEdit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                GrupID = Int32.Parse(dr[0].ToString());
            }
            baglan.baglanti().Close();
            grupListesi();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand silkomut = new SqlCommand("Delete From Musteriler Where Musteri_ID = @p1",baglan.baglanti());
            silkomut.Parameters.AddWithValue("@p1", MusteriID);
            silkomut.ExecuteNonQuery();
            listele();         
            baglan.baglanti().Close();
            MessageBox.Show("Müsteri Silindi.");
            temizle();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Grup_ID From Gruplar Where Grup_Adı=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", grupEdit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                GrupID = Int32.Parse(dr[0].ToString());
            }
            baglan.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("Update Musteriler Set Firma_Adi=@p1, Yetkili_Ad=@p2, il=@p3, " +
                "ilce=@p4, adres_line=@p5, telefon1=@p6, telefon2=@p7, mail=@p8, Grup_ID=@p9, Musteri_Not=@p10 Where Musteri_ID=@p11", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1",FirmaEditText.Text);
            komut2.Parameters.AddWithValue("p2", YetkiliTextEdit.Text);
            komut2.Parameters.AddWithValue("p3",ilEdit.Text);
            komut2.Parameters.AddWithValue("p4", ilceEdit.Text);
            komut2.Parameters.AddWithValue("p5", adresEditText.Text);
            komut2.Parameters.AddWithValue("p6", telEdit.Text);
            komut2.Parameters.AddWithValue("p7", telEdit2.Text);
            komut2.Parameters.AddWithValue("p8", mailText.Text);
            komut2.Parameters.AddWithValue("p9", GrupID);
            komut2.Parameters.AddWithValue("p10", notlarText.Text);
            komut2.Parameters.AddWithValue("p11", MusteriID);
            komut2.ExecuteNonQuery();
            baglan.baglanti().Close();
            listele();
            MessageBox.Show("Müsteri Güncellendi.");
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            this.MusteriID = Int32.Parse(dr["ID"].ToString());
            FirmaEditText.Text = dr["FirmaAdı"].ToString();
            YetkiliTextEdit.Text = dr["YetkiliAdı"].ToString();
            ilEdit.Text = dr["il"].ToString();
            SqlCommand komut = new SqlCommand("Select ilce, adres_line, telefon1, telefon2, mail, Grup_ID, Musteri_Not From Musteriler Where Musteri_ID = @p1",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",MusteriID);
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.Read())
            {
                ilceEdit.Text = datareader[0].ToString();
                adresEditText.Text = datareader[1].ToString();
                telEdit.Text = datareader[2].ToString();
                telEdit2.Text = datareader[3].ToString();
                mailText.Text = datareader[4].ToString();
                if (datareader[5].ToString() != "")
                {
                    GrupID = Int32.Parse(datareader[5].ToString());

                }
                else
                {
                    GrupID = 0;
                }
                
                notlarText.Text = datareader[6].ToString();
            }
            baglan.baglanti().Close();

            if (GrupID != 0)
            {

                SqlCommand komut2 = new SqlCommand("Select Grup_Adı From Gruplar Where Grup_ID = @p2", baglan.baglanti());
                komut2.Parameters.AddWithValue("@p2", GrupID);
                SqlDataReader dataReader2 = komut2.ExecuteReader();
                if (dataReader2.Read())
                {
                    grupEdit.Text = dataReader2[0].ToString();
                }
                baglan.baglanti().Close();

            }
            else
            {
                grupEdit.Text = "";
            }
            grupListesi();
        }
    }
}
