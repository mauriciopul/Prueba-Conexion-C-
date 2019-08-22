using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PruebaConexion
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=PruebaConexion;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion creada");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conectó: "+ex.ToString());
            }
        }


    }
}
