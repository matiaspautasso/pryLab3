using pryLab3.Ventas.ListaPrecios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab3.Ventas
{
    public partial class frmListaPrecProd : Form
    {
        public frmListaPrecProd()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();   frmAgregar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar frmEditar = new frmEditar(); frmEditar.ShowDialog();
        }
    }
}
