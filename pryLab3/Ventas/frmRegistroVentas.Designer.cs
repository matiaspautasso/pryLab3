namespace pryLab3.Ventas
{
    partial class frmRegistroVentas
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
            this.grpPanel = new System.Windows.Forms.Panel();
            this.grpaccion = new System.Windows.Forms.GroupBox();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelarVta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListRegVen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPanel.SuspendLayout();
            this.grpaccion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPanel
            // 
            this.grpPanel.AutoSize = true;
            this.grpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpPanel.Controls.Add(this.grpaccion);
            this.grpPanel.Controls.Add(this.comboBox1);
            this.grpPanel.Controls.Add(this.lbltipo);
            this.grpPanel.Controls.Add(this.panel2);
            this.grpPanel.Controls.Add(this.groupBox1);
            this.grpPanel.Controls.Add(this.ListRegVen);
            this.grpPanel.Controls.Add(this.txtCantidad);
            this.grpPanel.Controls.Add(this.label2);
            this.grpPanel.Controls.Add(this.txtCodigo);
            this.grpPanel.Controls.Add(this.label1);
            this.grpPanel.Location = new System.Drawing.Point(28, 12);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Size = new System.Drawing.Size(1123, 599);
            this.grpPanel.TabIndex = 0;
            this.grpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.grpPanel_Paint);
            // 
            // grpaccion
            // 
            this.grpaccion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.grpaccion.Controls.Add(this.btnmenos);
            this.grpaccion.Controls.Add(this.btnmas);
            this.grpaccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpaccion.Location = new System.Drawing.Point(905, 3);
            this.grpaccion.Name = "grpaccion";
            this.grpaccion.Size = new System.Drawing.Size(200, 100);
            this.grpaccion.TabIndex = 11;
            this.grpaccion.TabStop = false;
            // 
            // btnmenos
            // 
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(112, 29);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(50, 52);
            this.btnmenos.TabIndex = 8;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            // 
            // btnmas
            // 
            this.btnmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Location = new System.Drawing.Point(41, 29);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(50, 52);
            this.btnmas.TabIndex = 6;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(705, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 32);
            this.comboBox1.TabIndex = 10;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(620, 34);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(79, 24);
            this.lbltipo.TabIndex = 9;
            this.lbltipo.Text = "Tipo Op";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnCobrar);
            this.panel2.Controls.Add(this.btnCancelarVta);
            this.panel2.Location = new System.Drawing.Point(828, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 221);
            this.panel2.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(27, 152);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(220, 52);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(27, 3);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(220, 52);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVta
            // 
            this.btnCancelarVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVta.Location = new System.Drawing.Point(27, 76);
            this.btnCancelarVta.Name = "btnCancelarVta";
            this.btnCancelarVta.Size = new System.Drawing.Size(220, 52);
            this.btnCancelarVta.TabIndex = 1;
            this.btnCancelarVta.Text = "Cancelar venta";
            this.btnCancelarVta.UseVisualStyleBackColor = true;
            this.btnCancelarVta.Click += new System.EventHandler(this.btnCancelarVta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(828, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "$$$$$";
            // 
            // ListRegVen
            // 
            this.ListRegVen.BackgroundImageTiled = true;
            this.ListRegVen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListRegVen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ListRegVen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRegVen.FullRowSelect = true;
            this.ListRegVen.GridLines = true;
            this.ListRegVen.HideSelection = false;
            this.ListRegVen.Location = new System.Drawing.Point(16, 121);
            this.ListRegVen.Name = "ListRegVen";
            this.ListRegVen.Size = new System.Drawing.Size(780, 440);
            this.ListRegVen.TabIndex = 4;
            this.ListRegVen.UseCompatibleStateImageBehavior = false;
            this.ListRegVen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "codigo";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nombre";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "cantidad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "precio";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "descto";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "t operacion";
            this.columnHeader7.Width = 110;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(394, 29);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 29);
            this.txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(85, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1163, 676);
            this.Controls.Add(this.grpPanel);
            this.Name = "frmRegistroVentas";
            this.Text = "frmRegistroVentas";
            this.Load += new System.EventHandler(this.frmRegistroVentas_Load);
            this.grpPanel.ResumeLayout(false);
            this.grpPanel.PerformLayout();
            this.grpaccion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel grpPanel;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListRegVen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCancelarVta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grpaccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}