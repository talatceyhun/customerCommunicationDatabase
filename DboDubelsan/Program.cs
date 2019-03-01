using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DboDubelsan
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //sqlbaglanti baglan = new sqlbaglanti();
            //SqlConnection connection = baglan.baglanti();

            //SqlCommand alterKomut = new SqlCommand("ALTER TABLE Musteriler " +
            //    "ALTER COLUMN Musteri_Tarih date",connection);
            //alterKomut.ExecuteNonQuery();
            //SqlCommand alter2 = new SqlCommand("ALTER TABLE Musteriler " +
            //    "ADD FOREIGN KEY( Grup_ID ) REFERENCES Gruplar( Grup_ID) ON UPDATE CASCADE ON DELETE SET NULL", connection);
            //alter2.ExecuteNonQuery();

            
        }
    }
}
