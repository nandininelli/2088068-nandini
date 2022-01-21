using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";

            var dlg = new OpenFileDialog();
            dlg.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = dlg.FileName;
                pictureBox1.ImageLocation = ImageLocation;
            }
        }
    }
}
