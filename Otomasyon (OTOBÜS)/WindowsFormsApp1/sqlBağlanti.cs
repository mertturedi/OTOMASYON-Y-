using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class sqlBağlanti
    {
        private string yol;
        public SqlConnection baglanti; // Bağlantı
        public DataTable tablo; // Tablo 
        public SqlDataAdapter adaptor; // 
        public SqlDataReader okuyucu;
        public SqlCommand komut;
        //  static string conString;
        DataTable tbl = new DataTable();

        public sqlBağlanti()
        {
            // yol = ConfigurationManager.ConnectionStrings["Veriyolu"].ConnectionString;
            // yol = "Data Source = 10.150.0.22; Initial Catalog = OkulOtomasyon; Integrated Security = SSPI; User ID = sa; Password = MEDIPOL";
            yol = "server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI;";
        }

        public void Baglan()
        {
            baglanti = new SqlConnection(yol);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
    }
}
