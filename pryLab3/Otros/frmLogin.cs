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

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.ShowDialog();   
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
