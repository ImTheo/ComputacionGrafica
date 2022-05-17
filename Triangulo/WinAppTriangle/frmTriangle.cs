using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriangle
{
    public partial class frmTriangle : Form
    {
        // Definición de un objeto de tipo CTriangle.
        private CTriangle ObjCTriangle = new CTriangle();

        public frmTriangle()
        {
            InitializeComponent();
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.

            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declaración de una variable boolena.
            bool Validate;

            // Lectura de datos.
            // Llamada a la función ReadData.
            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            // Verificación de la existencia de un triángulo.
            // Llamada a la función CheckTriangle.
            Validate = ObjCTriangle.CheckTriangle();

            // Si el valor de la variable booleana es verdadero,
            // entonce existe y se realizan algunos cálculos.
            if (Validate == true)
            {
                // Cálculo del perímetro de un triángulo.
                // Llamada a la función PerimeterTriangle.
                ObjCTriangle.PerimeterTriangle();
                // Cálculo del área de un triángulo.
                // Llamada a la función AreaTriangle.
                ObjCTriangle.AreaTriangle();
                // Impresión de datos.
                // Llamada a la función PrintData.
                ObjCTriangle.PrintData(txtPerimeter, txtArea);
                // Graficación de un triángulo.
                // Llamada a la función PlotShape.
                ObjCTriangle.PlotShape(picCanvas);
            }
            // Caso Contrario, el triángulo no existe.
            else // !(Validate == true)
            {
                MessageBox.Show("Error...el triángulo no existe.",
                                "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            ObjCTriangle.CloseForm(this);
        }

        private void trackBarLadoA_Scroll(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            txtSideA.ResetText();
            txtSideA.AppendText((trackBarLadoA.Value).ToString());
            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            if (ObjCTriangle.CheckTriangle())
            {
                btnCalculate_Click(sender, e);
            }
        }

        private void trackBarLadoB_Scroll(object sender, EventArgs e)
        {

            picCanvas.Refresh();
            txtSideB.ResetText();
            txtSideB.AppendText((trackBarLadoB.Value).ToString());
            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            if (ObjCTriangle.CheckTriangle())
            {
                btnCalculate_Click(sender, e);
            }
        }

        private void trackBarLadoC_Scroll(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            txtSideC.ResetText();
            txtSideC.AppendText((trackBarLadoC.Value).ToString());
            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            if (ObjCTriangle.CheckTriangle())
            {
                btnCalculate_Click(sender, e);
            }
        }

        private bool ComprobarTriangulo(int ladoA, int ladoB, int ladoC)
        {
            bool ret;
            if (ladoA + ladoB > ladoC && ladoB + ladoC > ladoA && ladoC + ladoA > ladoB)
            {
                return true;
            }
            return false;
        }

    }



}
