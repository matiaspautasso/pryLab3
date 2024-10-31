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

        private void lblIrACrearCta_Click(object sender, EventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();   
            frmRegistrarse.ShowDialog();    
        }

        private void lblIrAInicio_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
        }
    }
}
