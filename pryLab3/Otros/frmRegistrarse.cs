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
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        private void lblIni_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
        }
    }
}
