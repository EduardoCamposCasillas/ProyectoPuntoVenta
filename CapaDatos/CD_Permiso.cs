using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();
            Conexion cone = new Conexion();
            MySqlCommand Query;
            try
            {
                StringBuilder queryString = new StringBuilder();
                queryString.AppendLine("SELECT p.IdRol, p.NombreMenu FROM PERMISO p");
                queryString.AppendLine("INNER JOIN ROL r On r.IdRol = p.IdRol");
                queryString.AppendLine("INNER JOIN USUARIO u on u.IdRol = r.IdRol");
                queryString.AppendLine("WHERE u.IdUsuario = @idusuario");

                Query = new MySqlCommand(queryString.ToString(), cone.Conectar());
                Query.Parameters.AddWithValue("@idusuario", idusuario);
                Query.Prepare();


                using (MySqlDataReader reader = Query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Permiso()
                        {
                            oRol = new Rol() { IdRol = Convert.ToInt32(reader["IdRol"]) },
                            NombreMenu = reader["NombreMenu"].ToString(),
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                lista = new List<Permiso>();
                MessageBox.Show(ex.Message);

            }

            return lista;
        }
    }
}
