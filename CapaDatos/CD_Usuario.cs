using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            Conexion cone = new Conexion();
            MySqlCommand Query;
            try
            {
                Query = new MySqlCommand("SELECT IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado FROM usuario", cone.Conectar());
                Query.Prepare();


                using (MySqlDataReader reader = Query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                            Documento = reader["Documento"].ToString(),
                            NombreCompleto = reader["NombreCompleto"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Clave = reader["Clave"].ToString(),
                            Estado = Convert.ToBoolean(reader["Estado"])
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                lista = new List<Usuario>();
                MessageBox.Show(ex.Message);

            }

            return lista;
        }
    }
}
