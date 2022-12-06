using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.control;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        Conexion cone = new Conexion();

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cbxEstado.Items.Add(new OpcionesCombo() { Valor = 1, Texto = "Activo"});
            cbxEstado.Items.Add(new OpcionesCombo() { Valor = 0, Texto = "No Activo" });

            cbxEstado.DisplayMember = "Texto";
            cbxEstado.ValueMember = "Valor";
            cbxEstado.SelectedIndex = 0;

            List<Rol> ListaRol = new CN_Rol().Listar();
            foreach (Rol item in ListaRol)
            {
                cbxRol.Items.Add(new OpcionesCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cbxRol.DisplayMember = "Texto";
            cbxRol.ValueMember = "Valor";
            cbxRol.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dtgData.Columns)
            {
                if (column.Visible == true && column.Name != "btnSeleccionar")
                {
                    cbxBuscar.Items.Add(new OpcionesCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cbxBuscar.DisplayMember = "Texto";
            cbxBuscar.ValueMember = "Valor";
            cbxBuscar.SelectedIndex = 0;

            //Mostrar Todos los Usuarios

            List<Usuario> ListaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in ListaUsuario)
            {
                dtgData.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
            });
            }
        }

        public void InsertarDatos()
        {
            
            MySqlCommand Query;
            string insert = "INSERT INTO `usuario` (`IdUsuario`, `Documento`, `NombreCompleto`, `Correo`, `Estado`, `Clave`," +
                " `FechaRegistro`, `IdRol`) VALUES (NULL, '@Documento', '@NombreCompleto', '@Correo', '@Estado', '@Clave', current_timestamp(), '@IdRol')";
            try
            {
                Query = new MySqlCommand(insert, cone.Conectar());
                Query.Prepare();
                Query.Parameters.AddWithValue("@Documento",txtDocumento.Text);
                Query.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
                Query.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                Query.Parameters.AddWithValue("@Estado", cbxEstado.SelectedIndex);
                Query.Parameters.AddWithValue("@Clave", txtClave.Text);
                Query.Parameters.AddWithValue("@IdRol", cbxRol.SelectedIndex);

                cone.Conectar();
                int result = Query.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnIconGuardar_Click(object sender, EventArgs e)
        {

            dtgData.Rows.Add(new object[] { "", txtId.Text, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text, txtClave.Text, 
                ((OpcionesCombo)cbxRol.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cbxRol.SelectedItem).Texto.ToString(),
                ((OpcionesCombo)cbxEstado.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cbxEstado.SelectedItem).Texto.ToString(),
            });
            InsertarDatos();

            Limpiar();
        }

        private void Limpiar()
        {
            txtIndex.Text = "";
            txtId.Text = "";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cbxRol.SelectedIndex = 0;
            cbxEstado.SelectedIndex= 0;

        }

        private void dtgData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
                

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.cheque.Width;
                var h = Properties.Resources.cheque.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cheque, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            

        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgData.Columns[e.ColumnIndex].Name == "btnSelec")
            {
                int index = e.RowIndex;

                if (index >= 0)
                {
                    txtIndex.Text = index.ToString();
                    txtId.Text = dtgData.Rows[index].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Text = dtgData.Rows[index].Cells["NroDocumento"].Value.ToString();
                    txtNombreCompleto.Text = dtgData.Rows[index].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dtgData.Rows[index].Cells["Correo"].Value.ToString();
                    txtClave.Text = dtgData.Rows[index].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = dtgData.Rows[index].Cells["Clave"].Value.ToString();

                    foreach (OpcionesCombo oc in cbxRol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgData.Rows[index].Cells["IdRol"].Value))
                        {
                            int index_combo = cbxRol.Items.IndexOf(oc);
                            cbxRol.SelectedIndex = index_combo;
                            break;
                        }
                    }

                    foreach(OpcionesCombo oc in cbxEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dtgData.Rows[index].Cells["EstadoValor"].Value))
                        {
                            int index_combo = cbxEstado.Items.IndexOf(oc);
                            cbxEstado.SelectedIndex = index_combo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
