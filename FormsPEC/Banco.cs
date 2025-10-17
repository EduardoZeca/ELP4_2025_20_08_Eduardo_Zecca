using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduar\source\repos\FormsPEC\FormsPEC\ELP42025.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }
    }
}
