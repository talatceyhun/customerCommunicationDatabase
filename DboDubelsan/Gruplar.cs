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
    public partial class Gruplar : Form
    {
        sqlbaglanti baglan = new sqlbaglanti();

        private string grupAdi;
        private string grupAciklama;
        private int grupID;
        public string GrupAdi { get => grupAdi; set => grupAdi = value; }
        public string GrupAciklama { get => grupAciklama; set => grupAciklama = value; }
        public int GrupID { get => grupID; set => grupID = value; }

        public Gruplar()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grupAdıText_EditValueChanged(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            grupAdıText.Text = "";
            grupAciklamaText.Text = "";
        }

        void listeleGrup()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Grup_ID as ID, Grup_Adı as GrupAdı, Grup_Aciklama as GrupAçıklaması " +
                "From Gruplar",baglan.baglanti());
            da.Fill(dt);
            grupControl.DataSource = dt;
            baglan.baglanti().Close();
        }

        public void listeleGrupUyeleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Grup_Adı as GrupAdı, Firma_Adi as FirmaAdı, telefon1 as Telefon," +
                "mail as Mail From Gruplar, Musteriler Where Gruplar.Grup_ID = Musteriler.Grup_ID",baglan.baglanti());
            da.Fill(dt);
            grupUyeleriControl.DataSource = dt;
            baglan.baglanti().Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)// kaydetButton
        {
            this.GrupAdi = grupAdıText.Text;
            this.GrupAciklama = grupAciklamaText.Text;
            SqlCommand komut = new SqlCommand("Insert Into Gruplar (Grup_Adı, Grup_Aciklama) VALUES (@p1, @p2)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", GrupAdi);
            komut.Parameters.AddWithValue("@p2", GrupAciklama);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            listeleGrup();
            listeleGrupUyeleri();           
            MessageBox.Show("Grup Kaydedildi.");
            temizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand silkomut = new SqlCommand("Delete From Gruplar Where Grup_ID = @p1", baglan.baglanti());
            silkomut.Parameters.AddWithValue("@p1", GrupID);
            silkomut.ExecuteNonQuery();
            baglan.baglanti().Close();
            listeleGrup();
            listeleGrupUyeleri();           
            MessageBox.Show("Grup Silindi.");
            temizle();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Gruplar Set Grup_Adı=@p2, Grup_Aciklama=@p3 Where Grup_ID=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", GrupID);
            komut.Parameters.AddWithValue("@p2", grupAdıText.Text);
            komut.Parameters.AddWithValue("@p3", grupAciklamaText.Text);
            komut.ExecuteNonQuery();
            baglan.baglanti().Close();
            listeleGrup();
            listeleGrupUyeleri();           
            MessageBox.Show("Grup Güncellendi.");
            temizle();

        }

        private void Gruplar_Load(object sender, EventArgs e)
        {
            listeleGrup();
            listeleGrupUyeleri();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            this.GrupID = Int32.Parse(dr["ID"].ToString());
            grupAdıText.Text = dr["GrupAdı"].ToString();
            grupAciklamaText.Text = dr["GrupAçıklaması"].ToString();


        }
    }
}
