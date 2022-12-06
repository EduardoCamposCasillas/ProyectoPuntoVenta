using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            Conexion cone = new Conexion();
            MySqlCommand Query;
            try
            {
                StringBuilder queryString = new StringBuilder();
                queryString.AppendLine("SELECT IdRol, Descripcion FROM ROL");

                Query = new MySqlCommand(queryString.ToString(), cone.Conectar());
                Query.Prepare();


                using (MySqlDataReader reader = Query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Rol()
                        {
                            IdRol = Convert.ToInt32(reader["IdRol"]),
                            Descripcion = reader["Descripcion"].ToString(),
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                lista = new List<Rol>();
                MessageBox.Show(ex.Message);

            }

            return lista;
        }
    }
}
