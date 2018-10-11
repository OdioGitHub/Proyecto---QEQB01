using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace QEQ1.Models
{
    public class BD
    {
        public static string connectionString = "Server=10.128.8.16.;Database=QEQB01;Trusted_connection=true;";
        private static SqlConnection conectar()
        {
            SqlConnection sqlConectar = new SqlConnection(connectionString);
            sqlConectar.Open();
            return sqlConectar;
        }
        private static void desconectar(SqlConnection desconexion)
        {
            desconexion.Close();
        }
    }
}