using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Eduardo_Campos.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace Eduardo_Campos
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

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
                cbxBuscar.DisplayMember = "Texto";
                cbxBuscar.ValueMember = "Valor";
                //cbxBuscar.SelectedIndex = 0;
            }
        }

        private void btnIconGuardar_Click(object sender, EventArgs e)
        {
            dtgData.Rows.Add(new object[] { "", txtId.Text, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text, txtCorreo.Text, 
                ((OpcionesCombo)cbxRol.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cbxRol.SelectedItem).Texto.ToString(),
                ((OpcionesCombo)cbxEstado.SelectedItem).Valor.ToString(),
                ((OpcionesCombo)cbxEstado.SelectedItem).Texto.ToString(),
            });

            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtDocumento.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtContra.Text = "";
            txtConfirmarContra.Text = "";
            cbxRol.SelectedIndex = 0;
            cbxEstado.SelectedIndex= 0;

        }
    }
}
