namespace pryLab3
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.MenuInicio = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosProveedoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosHistoricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuInicio
            // 
            this.MenuInicio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.MenuInicio.Location = new System.Drawing.Point(0, 0);
            this.MenuInicio.Name = "MenuInicio";
            this.MenuInicio.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.MenuInicio.Size = new System.Drawing.Size(719, 37);
            this.MenuInicio.TabIndex = 2;
            this.MenuInicio.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentasToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem,
            this.preciosProductosToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de ventas";
            this.historialDeVentasToolStripMenuItem.Click += new System.EventHandler(this.historialDeVentasToolStripMenuItem_Click);
            // 
            // preciosProductosToolStripMenuItem1
            // 
            this.preciosProductosToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciosProductosToolStripMenuItem1.Name = "preciosProductosToolStripMenuItem1";
            this.preciosProductosToolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.preciosProductosToolStripMenuItem1.Text = "Precios productos";
            this.preciosProductosToolStripMenuItem1.Click += new System.EventHandler(this.preciosProductosToolStripMenuItem1_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroComprasToolStripMenuItem,
            this.inventariosToolStripMenuItem1,
            this.preciosProveedoresToolStripMenuItem2,
            this.agendaProveedoresToolStripMenuItem1});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registroComprasToolStripMenuItem
            // 
            this.registroComprasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroComprasToolStripMenuItem.Name = "registroComprasToolStripMenuItem";
            this.registroComprasToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.registroComprasToolStripMenuItem.Text = "Registro compras";
            // 
            // inventariosToolStripMenuItem1
            // 
            this.inventariosToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariosToolStripMenuItem1.Name = "inventariosToolStripMenuItem1";
            this.inventariosToolStripMenuItem1.Size = new System.Drawing.Size(227, 24);
            this.inventariosToolStripMenuItem1.Text = "Inventarios";
            // 
            // preciosProveedoresToolStripMenuItem2
            // 
            this.preciosProveedoresToolStripMenuItem2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciosProveedoresToolStripMenuItem2.Name = "preciosProveedoresToolStripMenuItem2";
            this.preciosProveedoresToolStripMenuItem2.Size = new System.Drawing.Size(227, 24);
            this.preciosProveedoresToolStripMenuItem2.Text = "Precios proveedores";
            // 
            // agendaProveedoresToolStripMenuItem1
            // 
            this.agendaProveedoresToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaProveedoresToolStripMenuItem1.Name = "agendaProveedoresToolStripMenuItem1";
            this.agendaProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(227, 24);
            this.agendaProveedoresToolStripMenuItem1.Text = "Agenda proveedores";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosEgresosToolStripMenuItem,
            this.movimientosHistoricosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.inventarioToolStripMenuItem.Text = "Caja";
            // 
            // ingresosEgresosToolStripMenuItem
            // 
            this.ingresosEgresosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresosEgresosToolStripMenuItem.Name = "ingresosEgresosToolStripMenuItem";
            this.ingresosEgresosToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.ingresosEgresosToolStripMenuItem.Text = "Ingresos/Egresos";
            // 
            // movimientosHistoricosToolStripMenuItem
            // 
            this.movimientosHistoricosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosHistoricosToolStripMenuItem.Name = "movimientosHistoricosToolStripMenuItem";
            this.movimientosHistoricosToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.movimientosHistoricosToolStripMenuItem.Text = "Movimientos historicos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listaUsuariosToolStripMenuItem
            // 
            this.listaUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsuariosToolStripMenuItem.Name = "listaUsuariosToolStripMenuItem";
            this.listaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.listaUsuariosToolStripMenuItem.Text = "Lista Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(149)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(136, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "ComercioPro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(719, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuInicio);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.MenuInicio.ResumeLayout(false);
            this.MenuInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuInicio;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosHistoricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosProveedoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem agendaProveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosProductosToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

