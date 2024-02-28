using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace prueba4
{
    internal class maxi2
    {
        public static int agregar(maxi1 maxi1)
        {
            int retorna = 0;

            using (SqlConnection conn = Conex.obtenerc())
            {
                string query = "insert into super () values ('" + Est1.carnet + "' , '" + Est1.nombre + "' , '" + Est1.apelli + "' , '" + Est1.acum + "' , '" + Est1.exam + "' , '" + Est1.final + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

                retorna = cmd.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
