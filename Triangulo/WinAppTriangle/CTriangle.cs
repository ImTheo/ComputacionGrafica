using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppTriangle
{
    class CTriangle
    {
        // Datos Miembro (Atributos).

        // Lado 1 del triángulo.
        private float a;
        // Lado 2 del triángulo.
        private float b;
        // Lado 3 del triángulo.
        private float c;
        // Perímetro del triángulo.
        private float perimeter;
        // Área del triángulo.
        private float area;
        // Objeto que activa el modo gráfico.
        private Graphics mGraph;
        // Objeto bolígrafo que dibuja o escribe en un lienzo (canvas).
        private Pen mPen;
        // Constante scale factor (Zoom In/Zoom Out).
        private const float SF = 10;
        // Objeto Punto que representa al vértice A del triángulo.
        private PointF A;
        // Objeto Punto que representa al vértice B del triángulo.
        private PointF B;
        // Objeto Punto que representa al vértice C del triángulo.
        private PointF C;
        // Ángulo A del triángulo.
        private float angleA;

        // Funciones Miembro (Métodos).

        // Constructor sin parámetros.
        public CTriangle()
        {
            a = 0.0f; b = 0.0f; c = 0.0f;
            perimeter = 0.0f; area = 0.0f;
        }

        // Función que lee los tres lados del triángulo.
        // ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
        // txtSideA = txtSideA; txtSideB = txtSideB; txtSideC = txtSideC;
        public void ReadData(TextBox txtSideA,
                             TextBox txtSideB,
                             TextBox txtSideC)
        {
            try
            {
                a = float.Parse(txtSideA.Text);
                b = float.Parse(txtSideB.Text);
                c = float.Parse(txtSideC.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        // Función que calcula el semi-perímetro del triángulo.
        private float SemiperimeterTriangle()
        {
            return ((a + b + c) / 2);
        }

        // Función que calcula el perímetro del triángulo.
        public void PerimeterTriangle()
        {
            float s = SemiperimeterTriangle();
            perimeter = 2 * s;
        }

        // Función que calcula el área del triángulo.
        public void AreaTriangle()
        {
            float s = SemiperimeterTriangle();
            area = (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        // Función que imprime el perímetro y el área del triángulo.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        // Función que inicializa los datos y controles del triángulo.
        public void InitializeData(TextBox txtSideA, TextBox txtSideB,
                                   TextBox txtSideC, TextBox txtPerimeter,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            a = 0.0f; b = 0.0f; c = 0.0f;
            perimeter = 0.0f; area = 0.0f;
            txtSideA.Text = "0"; txtSideB.Text = "0"; txtSideC.Text = "0";
            txtPerimeter.Text = ""; txtArea.Text = "";
            // Mantiene el cursor titilando en una caja de texto.
            txtSideA.Focus();
            picCanvas.Refresh();
        }

        // Función que valida la existencia de un triángulo.
        // Validate = ObjCTriangle.CheckTriangle();
        public bool CheckTriangle()
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return (true);
            }
            else // !((a + b > c) && (a + c > b) && (b + c > a))
                return (false);
        }

        // Función que calcula el ángulo A del triángulo.
        private void CalculateAngleA()
        {
            angleA = (float)Math.Acos((b * b + c * c - a * a) / (2 * b * c));
        }

        // Función que calcula los valores de los tres vértices del triángulo.  
        private void CalculateVertex()
        {
            A.X = 0.0f; A.Y = 0.0f;
            B.X = c; B.Y = 0.0f;

            CalculateAngleA();

            C.X = b * (float)Math.Cos(angleA);
            C.Y = b * (float)Math.Sin(angleA);
        }

        // Función que grafica un triángulo en base a los tres
        // vértices, representados por tres puntos en un plano.
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            CalculateVertex();

            // Graficar las tres líneas que conforman un triángulo.
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, B.X * SF, B.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, C.X * SF, C.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, C.X * SF, C.Y * SF);
        }

        // Función que cierra un formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

        public bool CheckTriangleSize(int a,int b,int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return (true);
            }
            else // !((a + b > c) && (a + c > b) && (b + c > a))
                return (false);
        }
    }



}
