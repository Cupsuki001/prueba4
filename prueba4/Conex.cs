using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace prueba4
{
    public class Conex
    {
        public static SqlConnection obtenerc()
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=super;Data Source=DESKTOP-E4EN6EA\\SQLEXPRESS");
            con.Open();

            return con;
        }
    }
}
