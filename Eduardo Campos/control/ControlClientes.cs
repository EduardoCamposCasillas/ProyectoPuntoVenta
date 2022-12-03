using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eduardo_Campos.control;

namespace Eduardo_Campos.control
{
    internal class ControlClientes : Conexion
    {
       // Conexion conexion = new Conexion();
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        public void LlenaCombo(ComboBox combo)
        {
            try
            {
                Query = new MySqlCommand(
                    "SELECT * FROM tblusuarios", Conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();



            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        //-------------------------------------------------------
        public void LlenarTablaClientes(DataGridView tabla)
        {
            tabla.Rows.Clear();

            try
            {
                Query = new MySqlCommand("SELECT * FROM tblusuarios", Conectar());
                Query.Prepare();
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    tabla.Rows.Add(consultar["id"].ToString(), 
                        consultar["nombre"].ToString(), 
                        consultar["apellido"].ToString(),
                        consultar["id"].ToString());
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
