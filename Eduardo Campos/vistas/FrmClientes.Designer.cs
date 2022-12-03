namespace Eduardo_Campos.vistas
{
    partial class FrmClientes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApepat = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApemat = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsulatr = new System.Windows.Forms.Button();
            this.cbxDatos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(737, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(360, 26);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(143, 180);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(310, 26);
            this.txtApellidoMaterno.TabIndex = 8;
            // 
            // lblApepat
            // 
            this.lblApepat.AutoSize = true;
            this.lblApepat.Location = new System.Drawing.Point(12, 129);
            this.lblApepat.Name = "lblApepat";
            this.lblApepat.Size = new System.Drawing.Size(125, 20);
            this.lblApepat.TabIndex = 7;
            this.lblApepat.Text = "Apellido Paterno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(143, 126);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(310, 26);
            this.txtApellidoPaterno.TabIndex = 6;
            // 
            // lblApemat
            // 
            this.lblApemat.AutoSize = true;
            this.lblApemat.Location = new System.Drawing.Point(12, 180);
            this.lblApemat.Name = "lblApemat";
            this.lblApemat.Size = new System.Drawing.Size(128, 20);
            this.lblApemat.TabIndex = 5;
            this.lblApemat.Text = "Apellido Materno";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(143, 282);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(310, 26);
            this.txtCalle.TabIndex = 12;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 231);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(143, 228);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(310, 26);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(12, 282);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 20);
            this.lblCalle.TabIndex = 9;
            this.lblCalle.Text = "Calle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 272);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 665);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 38);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(296, 665);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(182, 38);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(572, 665);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 38);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsulatr
            // 
            this.btnConsulatr.Location = new System.Drawing.Point(852, 665);
            this.btnConsulatr.Name = "btnConsulatr";
            this.btnConsulatr.Size = new System.Drawing.Size(182, 38);
            this.btnConsulatr.TabIndex = 17;
            this.btnConsulatr.Text = "Consulatr";
            this.btnConsulatr.UseVisualStyleBackColor = true;
            // 
            // cbxDatos
            // 
            this.cbxDatos.FormattingEnabled = true;
            this.cbxDatos.Location = new System.Drawing.Point(572, 75);
            this.cbxDatos.Name = "cbxDatos";
            this.cbxDatos.Size = new System.Drawing.Size(67, 28);
            this.cbxDatos.TabIndex = 18;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 730);
            this.Controls.Add(this.cbxDatos);
            this.Controls.Add(this.btnConsulatr);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApepat);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApemat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApepat;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApemat;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsulatr;
        private System.Windows.Forms.ComboBox cbxDatos;
    }
}