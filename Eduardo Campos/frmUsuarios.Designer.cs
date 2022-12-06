namespace Eduardo_Campos
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContenedor = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.lblConfirmarContra = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnIconGuardar = new FontAwesome.Sharp.IconButton();
            this.btnIconEditar = new FontAwesome.Sharp.IconButton();
            this.btnIconEliminar = new FontAwesome.Sharp.IconButton();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.btnIconBuscar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContenedor
            // 
            this.lblContenedor.BackColor = System.Drawing.Color.White;
            this.lblContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblContenedor.Location = new System.Drawing.Point(0, 0);
            this.lblContenedor.Name = "lblContenedor";
            this.lblContenedor.Size = new System.Drawing.Size(289, 716);
            this.lblContenedor.TabIndex = 0;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(120, 20);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "No. Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(16, 32);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(211, 26);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(16, 109);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(211, 26);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(18, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(16, 193);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(211, 26);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(12, 157);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 20);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(16, 268);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(211, 26);
            this.txtContra.TabIndex = 9;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.White;
            this.lblContra.Location = new System.Drawing.Point(12, 235);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(92, 20);
            this.lblContra.TabIndex = 8;
            this.lblContra.Text = "Contraseña";
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(16, 343);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.PasswordChar = '*';
            this.txtConfirmarContra.Size = new System.Drawing.Size(211, 26);
            this.txtConfirmarContra.TabIndex = 11;
            // 
            // lblConfirmarContra
            // 
            this.lblConfirmarContra.AutoSize = true;
            this.lblConfirmarContra.BackColor = System.Drawing.Color.White;
            this.lblConfirmarContra.Location = new System.Drawing.Point(12, 309);
            this.lblConfirmarContra.Name = "lblConfirmarContra";
            this.lblConfirmarContra.Size = new System.Drawing.Size(165, 20);
            this.lblConfirmarContra.TabIndex = 10;
            this.lblConfirmarContra.Text = "Confirmar Contraseña";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(12, 383);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 20);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Rol";
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(16, 415);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(211, 28);
            this.cbxRol.TabIndex = 13;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(16, 494);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(211, 28);
            this.cbxEstado.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(12, 457);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // btnIconGuardar
            // 
            this.btnIconGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIconGuardar.IconColor = System.Drawing.Color.Black;
            this.btnIconGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconGuardar.Location = new System.Drawing.Point(16, 545);
            this.btnIconGuardar.Name = "btnIconGuardar";
            this.btnIconGuardar.Size = new System.Drawing.Size(211, 38);
            this.btnIconGuardar.TabIndex = 16;
            this.btnIconGuardar.Text = "Guardar";
            this.btnIconGuardar.UseVisualStyleBackColor = true;
            this.btnIconGuardar.Click += new System.EventHandler(this.btnIconGuardar_Click);
            // 
            // btnIconEditar
            // 
            this.btnIconEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIconEditar.IconColor = System.Drawing.Color.Black;
            this.btnIconEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconEditar.Location = new System.Drawing.Point(16, 589);
            this.btnIconEditar.Name = "btnIconEditar";
            this.btnIconEditar.Size = new System.Drawing.Size(211, 38);
            this.btnIconEditar.TabIndex = 17;
            this.btnIconEditar.Text = "Editar";
            this.btnIconEditar.UseVisualStyleBackColor = true;
            // 
            // btnIconEliminar
            // 
            this.btnIconEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIconEliminar.IconColor = System.Drawing.Color.Black;
            this.btnIconEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconEliminar.Location = new System.Drawing.Point(16, 633);
            this.btnIconEliminar.Name = "btnIconEliminar";
            this.btnIconEliminar.Size = new System.Drawing.Size(211, 38);
            this.btnIconEliminar.TabIndex = 18;
            this.btnIconEliminar.Text = "Eliminar";
            this.btnIconEliminar.UseVisualStyleBackColor = true;
            // 
            // dtgData
            // 
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdUsuario,
            this.NroDocumento,
            this.Correo,
            this.Clave,
            this.NombreCompleto,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.dtgData.Location = new System.Drawing.Point(293, 134);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersWidth = 62;
            this.dtgData.RowTemplate.Height = 28;
            this.dtgData.Size = new System.Drawing.Size(1085, 570);
            this.dtgData.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(289, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1101, 118);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(251, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 26);
            this.txtId.TabIndex = 21;
            this.txtId.Text = "0";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 150;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "NroDomento";
            this.NroDocumento.MinimumWidth = 8;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 8;
            this.Clave.Name = "Clave";
            this.Clave.Visible = false;
            this.Clave.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Width = 150;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.MinimumWidth = 8;
            this.IdRol.Name = "IdRol";
            this.IdRol.Visible = false;
            this.IdRol.Width = 150;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 8;
            this.Rol.Name = "Rol";
            this.Rol.Width = 150;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 8;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(784, 52);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 20);
            this.lblBuscar.TabIndex = 22;
            this.lblBuscar.Text = "Buscar por";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1030, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(152, 26);
            this.txtBuscar.TabIndex = 23;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Location = new System.Drawing.Point(876, 52);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(148, 28);
            this.cbxBuscar.TabIndex = 24;
            // 
            // btnIconBuscar
            // 
            this.btnIconBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.btnIconBuscar.IconColor = System.Drawing.Color.Black;
            this.btnIconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconBuscar.IconSize = 30;
            this.btnIconBuscar.Location = new System.Drawing.Point(1188, 45);
            this.btnIconBuscar.Name = "btnIconBuscar";
            this.btnIconBuscar.Size = new System.Drawing.Size(47, 35);
            this.btnIconBuscar.TabIndex = 25;
            this.btnIconBuscar.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1258, 42);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(91, 38);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.Text = "Editar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1390, 716);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnIconBuscar);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.btnIconEliminar);
            this.Controls.Add(this.btnIconEditar);
            this.Controls.Add(this.btnIconGuardar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtConfirmarContra);
            this.Controls.Add(this.lblConfirmarContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblContenedor);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContenedor;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label lblConfirmarContra;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstado;
        private FontAwesome.Sharp.IconButton btnIconGuardar;
        private FontAwesome.Sharp.IconButton btnIconEditar;
        private FontAwesome.Sharp.IconButton btnIconEliminar;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private FontAwesome.Sharp.IconButton btnIconBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}