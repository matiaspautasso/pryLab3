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

         
            signatureBitmap = new Bitmap(picMostrar.Width, picMostrar.Height);
            picMostrar.Image = signatureBitmap;
            picMostrar.MouseDown += PictureBox1_MouseDown;
            picMostrar.MouseMove += PictureBox1_MouseMove;
            picMostrar.MouseUp += PictureBox1_MouseUp;

        }

        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Bitmap signatureBitmap;
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(signatureBitmap))
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                picMostrar.Invalidate();
                lastPoint = e.Location;
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        public void SaveSignature(string path)
        {
            signatureBitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void lblIni_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
           
            this.Hide();
            frmLogin.ShowDialog();
            Close();
        }
        
        private void frmRegistrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
