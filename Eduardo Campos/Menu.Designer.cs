namespace Eduardo_Campos
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1ToolStripMenuItem,
            this.iconMenuItem2ToolStripMenuItem,
            this.iconMenuItem3ToolStripMenuItem,
            this.iconMenuItem4ToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 77);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1119, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1ToolStripMenuItem
            // 
            this.iconMenuItem1ToolStripMenuItem.Name = "iconMenuItem1ToolStripMenuItem";
            this.iconMenuItem1ToolStripMenuItem.Size = new System.Drawing.Size(96, 64);
            this.iconMenuItem1ToolStripMenuItem.Text = "Usuarios";
            this.iconMenuItem1ToolStripMenuItem.Click += new System.EventHandler(this.iconMenuItem1ToolStripMenuItem_Click);
            // 
            // iconMenuItem2ToolStripMenuItem
            // 
            this.iconMenuItem2ToolStripMenuItem.Name = "iconMenuItem2ToolStripMenuItem";
            this.iconMenuItem2ToolStripMenuItem.Size = new System.Drawing.Size(125, 64);
            this.iconMenuItem2ToolStripMenuItem.Text = "Mantenedor";
            // 
            // iconMenuItem3ToolStripMenuItem
            // 
            this.iconMenuItem3ToolStripMenuItem.Name = "iconMenuItem3ToolStripMenuItem";
            this.iconMenuItem3ToolStripMenuItem.Size = new System.Drawing.Size(80, 64);
            this.iconMenuItem3ToolStripMenuItem.Text = "Ventas";
            // 
            // iconMenuItem4ToolStripMenuItem
            // 
            this.iconMenuItem4ToolStripMenuItem.Name = "iconMenuItem4ToolStripMenuItem";
            this.iconMenuItem4ToolStripMenuItem.Size = new System.Drawing.Size(100, 64);
            this.iconMenuItem4ToolStripMenuItem.Text = "Compras";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(89, 64);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(127, 64);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(98, 64);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(105, 64);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1119, 77);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1119, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iconMenuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconMenuItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconMenuItem3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconMenuItem4ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}