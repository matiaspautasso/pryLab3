namespace pryLab3.Otros
{
    partial class frmRecuperar
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
            this.lblIrAInicio = new System.Windows.Forms.Label();
            this.lblIrACrearCta = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.cmdEnviarEnlace = new System.Windows.Forms.Button();
            this.txtIngresarMail = new System.Windows.Forms.TextBox();
            this.lbltextRecupContra = new System.Windows.Forms.Label();
            this.lblProblemInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIrAInicio
            // 
            this.lblIrAInicio.AutoSize = true;
            this.lblIrAInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrAInicio.Location = new System.Drawing.Point(354, 369);
            this.lblIrAInicio.Name = "lblIrAInicio";
            this.lblIrAInicio.Size = new System.Drawing.Size(100, 17);
            this.lblIrAInicio.TabIndex = 31;
            this.lblIrAInicio.Text = "Volver Al Inicio";
            this.lblIrAInicio.Click += new System.EventHandler(this.lblIrAInicio_Click);
            // 
            // lblIrACrearCta
            // 
            this.lblIrACrearCta.AutoSize = true;
            this.lblIrACrearCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrACrearCta.Location = new System.Drawing.Point(345, 292);
            this.lblIrACrearCta.Name = "lblIrACrearCta";
            this.lblIrACrearCta.Size = new System.Drawing.Size(122, 17);
            this.lblIrACrearCta.TabIndex = 30;
            this.lblIrACrearCta.Text = "Crear Una Cuenta";
            this.lblIrACrearCta.Click += new System.EventHandler(this.lblIrACrearCta_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(398, 330);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(15, 13);
            this.lblC.TabIndex = 29;
            this.lblC.Text = "O";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(419, 330);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(157, 13);
            this.lblZ.TabIndex = 28;
            this.lblZ.Text = "_________________________";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(233, 330);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(157, 26);
            this.lblX.TabIndex = 27;
            this.lblX.Text = "_________________________\r\n\r\n";
            // 
            // cmdEnviarEnlace
            // 
            this.cmdEnviarEnlace.BackColor = System.Drawing.Color.White;
            this.cmdEnviarEnlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnviarEnlace.ForeColor = System.Drawing.Color.Black;
            this.cmdEnviarEnlace.Location = new System.Drawing.Point(236, 232);
            this.cmdEnviarEnlace.Name = "cmdEnviarEnlace";
            this.cmdEnviarEnlace.Size = new System.Drawing.Size(330, 39);
            this.cmdEnviarEnlace.TabIndex = 26;
            this.cmdEnviarEnlace.Text = "Enviar enlace de inicio de sesión";
            this.cmdEnviarEnlace.UseVisualStyleBackColor = false;
            // 
            // txtIngresarMail
            // 
            this.txtIngresarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarMail.Location = new System.Drawing.Point(236, 185);
            this.txtIngresarMail.Multiline = true;
            this.txtIngresarMail.Name = "txtIngresarMail";
            this.txtIngresarMail.Size = new System.Drawing.Size(330, 29);
            this.txtIngresarMail.TabIndex = 25;
            // 
            // lbltextRecupContra
            // 
            this.lbltextRecupContra.AutoSize = true;
            this.lbltextRecupContra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextRecupContra.Location = new System.Drawing.Point(148, 106);
            this.lbltextRecupContra.Name = "lbltextRecupContra";
            this.lbltextRecupContra.Size = new System.Drawing.Size(428, 57);
            this.lbltextRecupContra.TabIndex = 24;
            this.lbltextRecupContra.Text = "                                  Ingresa tu correo electrónico \r\n               " +
    "   y te enviaremos un enlace para que recuperes \r\n                              " +
    "        el acceso a tu cuenta.";
            // 
            // lblProblemInicio
            // 
            this.lblProblemInicio.AutoSize = true;
            this.lblProblemInicio.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemInicio.ForeColor = System.Drawing.Color.White;
            this.lblProblemInicio.Location = new System.Drawing.Point(173, 27);
            this.lblProblemInicio.Name = "lblProblemInicio";
            this.lblProblemInicio.Size = new System.Drawing.Size(431, 31);
            this.lblProblemInicio.TabIndex = 23;
            this.lblProblemInicio.Text = "¿Tienes problemas para iniciar sesión?";
            // 
            // frmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.lblIrAInicio);
            this.Controls.Add(this.lblIrACrearCta);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.cmdEnviarEnlace);
            this.Controls.Add(this.txtIngresarMail);
            this.Controls.Add(this.lbltextRecupContra);
            this.Controls.Add(this.lblProblemInicio);
            this.Name = "frmRecuperar";
            this.Text = "Recuperar";
            this.Load += new System.EventHandler(this.frmRecuperar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIrAInicio;
        private System.Windows.Forms.Label lblIrACrearCta;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button cmdEnviarEnlace;
        private System.Windows.Forms.TextBox txtIngresarMail;
        private System.Windows.Forms.Label lbltextRecupContra;
        private System.Windows.Forms.Label lblProblemInicio;
    }
}