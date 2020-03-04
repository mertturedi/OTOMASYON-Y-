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
   public class sqlBağlanti
    {

        SqlConnection kom = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
        public void Connect()
        {
            if (kom.State == ConnectionState.Closed)
            {
                kom.Open();
            }
        }









    }
}
