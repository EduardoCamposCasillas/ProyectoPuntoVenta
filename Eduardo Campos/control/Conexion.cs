using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Eduardo_Campos.control
{
    internal class Conexion
    {
        //conexion a base de datos
        public const string servidor = "localhost";
        public const string bd = "puntoventa";
        public const string usuario = "root";
        public const string password = "";

        public string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + ";";
        public MySqlConnection con;

        public MySqlConnection Conectar()
        {
            con = new MySqlConnection(cadenaConexion);

            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                con.Open();
                MessageBox.Show(mensajes.Mensajes.conBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return con;
        }

        public void Desconectar()
        {
            con.Close();
        }
    }
}
