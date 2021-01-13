using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painter
{
    public partial class Painter_Form : Form
    {
        Bitmap bm = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;
        
        public Painter_Form()
        {

            InitializeComponent();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bm);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image = bm;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDİalog1 = new SaveFileDialog();
            saveFileDİalog1.Filter = "Files|*.jpeg;*.bmp;*.png;";
            saveFileDİalog1.Title = "Save File";
            saveFileDİalog1.ShowDialog();
            if(saveFileDİalog1.FileName != null)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDİalog1.OpenFile();
                switch (saveFileDİalog1.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
