using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DboDubelsan
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-UOKUQI6\SQLEXPRESS; Initial Catalog=DatabaseOtomasyon; Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
