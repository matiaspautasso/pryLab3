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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryLab3.Ventas
{
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }

        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
            dgvMostrar.Font = new Font("Arial", 14, FontStyle.Regular);



        }

        private void grpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        clsVentas ventas=new clsVentas();
        private void btnmas_Click(object sender, EventArgs e)
        {
            int codigo=int.Parse(txtCodigo.Text);
            int descuento=int.Parse(txtDescuento.Text);
            string tOperacion=cboTipoOp.Text;
           // ventas.MostrarGrillaConDescuento("LISTAPRECIOS",dgvMostrar,codigo,descuento,tOperacion);
        }
    }
}
