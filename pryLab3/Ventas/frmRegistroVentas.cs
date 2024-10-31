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
            ListRegVen.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent); // Primera columna
            ListRegVen.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            ListRegVen.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            ListRegVen.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            ListRegVen.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            int totalWidth = ListRegVen.ClientSize.Width;
            int columnCount = ListRegVen.Columns.Count;
            int columnWidth = totalWidth / columnCount;

            foreach (ColumnHeader column in ListRegVen.Columns)
            {
                column.Width = columnWidth;
            }

        }

        private void grpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
