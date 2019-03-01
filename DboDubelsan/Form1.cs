using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DboDubelsan
{
    public partial class Form1 : Form
    {
        public Musteriler musteri;
        public Gruplar grup;
        public Mail mail;

        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            musteri.Close();
            grup.Close();
            if (mail == null || mail.IsDisposed)
            {
                mail = new Mail();
                mail.MdiParent = this;
                mail.Show();
            }
        }

        private void buttonMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grup.Close();
            mail.Close();
            if(musteri == null || musteri.IsDisposed)
            {
                musteri = new Musteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Müşteri İletişim Veritabanı";
           
            grup = new Gruplar();
            mail = new Mail();
            grup.Close();
            mail.Close();
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new Musteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }

        private void buttonGruplar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mail.Close();
            musteri.Close();
            if (grup == null || grup.IsDisposed)
            {
                grup = new Gruplar();
                grup.MdiParent = this;
                grup.Show();

            }


        }
    }
}
