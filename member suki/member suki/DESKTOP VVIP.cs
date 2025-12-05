using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace member_suki
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=vvip\\sqlexpress ;Initial Catalog=DB_POS ;Integrated Security=True";
            return Conn;
        }
    }
}
