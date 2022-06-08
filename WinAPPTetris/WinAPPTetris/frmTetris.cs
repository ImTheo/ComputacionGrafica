using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPPTetris
{
    public partial class frmTetris : Form
    {
        TetrisApp tetris = new TetrisApp();
        public frmTetris()
        {
            InitializeComponent();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            tetris.Exit(picClose);
            tetris.GraficarAreaDeJuego(picCanvas);
            tetris.GraphNextArea(picCanvas);
            tetris.InititializeData();
        }

        private void frmTetris_Load(object sender, EventArgs e)
        {
            tetris.InititializeData();
        }

        private void picPause_Click(object sender, EventArgs e)
        {
           
        }

        private void picPause_MouseEnter(object sender, EventArgs e)
        {
            tetris.Pausa(picPause);
        }

        private void picPause_MouseLeave(object sender, EventArgs e)
        {
            tetris.RefreshPause(picPause);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
