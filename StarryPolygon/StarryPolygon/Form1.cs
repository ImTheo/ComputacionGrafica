using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarryPolygon
{
    public partial class Form1 : Form
    {
        CHexadecagon objHexadecagono = new CHexadecagon();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            objHexadecagono.readDataTriangle(txtSide);
            objHexadecagono.graphShape1(picCanvas);
            objHexadecagono.graphShape2(picCanvas);
            objHexadecagono.graphShape3(picCanvas);
            objHexadecagono.graphShape4(picCanvas);
            picCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objHexadecagono.inicializateData(txtSide, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
