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
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó: " + ex.ToString());
            }
        }

        public String insertar(int id, string nombre, string apellido, string fecha)
        {
            string salida = "Se insertó ";
            try
            {
                cmd = new SqlCommand(
                    "Insert into Persona(Id, Nombre, Apellidos, FechaNacimiento)" +
                    "values(" + id + ", '" + nombre + "', '" + apellido + "', '" + fecha + "')", cn
                    );
                cmd.ExecuteNonQuery();//Este comando es para que se ejecute la sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "Error al insertar dato: " + ex.ToString();
            }
            return salida;
        }

        public int personaRegistrada(int id)
        {
            int cont = 0;
            try
            {
                cmd = new SqlCommand(
                    "Select * from persona where id = "+id+"", cn
                    );
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cont++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar dato: " + ex.ToString());
            }
            return cont;
        }

    }
}
