using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = CapaPresentacion.control.Control;
using CapaPresentacion.entidades;
//using Conexion = Eduardo_Campos.control.Conexion;
using CapaPresentacion.control;
using CapaPresentacion.vistas;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngregar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtUser.Text && u.Clave == txtPass.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Menu form = new Menu(ousuario);

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se econtro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frm_closing(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
