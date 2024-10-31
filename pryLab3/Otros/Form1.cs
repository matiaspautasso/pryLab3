using pryLab3.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void registroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVentas frm =new frmRegistroVentas(); 
            frm.ShowDialog();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialVentas frm =new frmHistorialVentas(); frm.ShowDialog();
        }

        private void preciosProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaPrecProd frmListaPrecProd = new frmListaPrecProd(); frmListaPrecProd.ShowDialog();
        }
    }
}
