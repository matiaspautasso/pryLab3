using pryLab3.Clases;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //ClsConexion clsConexion = new ClsConexion();    clsConexion.VerificarConexion();
        }
        ClsUsuario ClsUsuario=new ClsUsuario();  

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario=txtUsuario.Text;
            string contrasena = txtContra.Text;

            bool usuariovalido=ClsUsuario.VerificarUsuario(usuario,contrasena);
           
           
            if (usuariovalido)
            {
                frmMenu menuPrincipal = new frmMenu();
                menuPrincipal.Show();
                this.Hide(); // Oculta en lugar de cerrar
            }


        }

        private void lblRecContraseña_Click(object sender, EventArgs e)
        {
            frmRecuperar frmRecuperar = new frmRecuperar();
            frmRecuperar.ShowDialog();  
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();   
            frmRegistrarse.ShowDialog();

        }
    }
}
