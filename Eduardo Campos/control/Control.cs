using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.entidades;
using CapaPresentacion.control;
using MySql.Data.MySqlClient;
using CapaPresentacion.recursos;

using CapaEntidad;

namespace CapaPresentacion.control
{
    internal class Control : Conexion
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;

        public byte ValidarUsuarios(Usuario usuario)
        {
            byte existe = 0;
            try
            {
                Query = new MySqlCommand(
                    "SELECT * FROM usuario " +
                    "WHERE Documento=@username " +
                    "AND Clave=@passwd",
                    Conectar());
                Query.Prepare();
                Query.Parameters.AddWithValue("@username", usuario.Documento);
                Query.Parameters.AddWithValue("@passwd", usuario.Clave);
                consultar = Query.ExecuteReader();
                consultar.Read();

                if (consultar.HasRows)
                {
                    string name = consultar["contra"].ToString();
                    Sesiones.nomusuario = usuario.Documento.ToString() + " " + name;
                    existe = 1;
                }
                else
                {
                    MessageBox.Show("Usuario no valido");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return existe;
        }

        public void InsertarUsuario()
        {

        }
        public void CargarTabla()
        {

        }
    }
}
