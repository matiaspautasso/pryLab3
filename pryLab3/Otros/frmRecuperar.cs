using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab3.Otros
{
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void frmRecuperar_Load(object sender, EventArgs e)
        {

        }
        public void MostrarMensajeRecuperacionCuenta()
        {
            if (txtIngresarMail.Text!="")
            {
                MessageBox.Show(
               "Enlace enviado",
               "Recuperación de cuenta",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly
           );
            }
            else
            {
                MessageBox.Show("completar correo porfavor");
            }
           
        }
        private void lblIrACrearCta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
           



        }
       
        private void lblIrAInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
        }

        private void cmdEnviarEnlace_Click(object sender, EventArgs e)
        {
            MostrarMensajeRecuperacionCuenta();
        }
    }
}
