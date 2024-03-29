﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppTriangle
{
    class CLine
    {
        // Datos miembro - Atributos de la clase.
        // Coeficientes numéricos de la ecuación.
        private float mA, mB, mC;
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 10;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        private PointF[] mP = new PointF[61];
        // Valores de 'x' y de 'y'.
        private float mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función (Dominio-x).
        private float I1, I2;

        // Constructores de la clase.
        // Constructor por defecto.
        public CLine()
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mX = 0.0f; mY = 0.0f; mXp = 0.0f; mYp = 0.0f;
        }

        // Funciones miembro - Métodos de la clase.
        // Función para leer los coeficientes numéricos.
        public void ReadData(TextBox txtA, TextBox txtB, TextBox txtC)
        {
            mA = float.Parse(txtA.Text);
            mB = float.Parse(txtB.Text);
            mC = float.Parse(txtC.Text);
        }
        // Función para graficar los ejes coordenados.
        // Área de dibujo es de 400x300
        // P0(0,0); P1(400,0); P2(0,300); P3(400,300)
        public void PlotAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Black);
            // Eje horizontal - eje x (paralelo al ancho-width del picCanvas).
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            // Eje vertical - eje y (paralelo al largo-height del picCanvas).
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
            // Centro Trasladado Cp(200,150)
        }

        public void PlotLineAB(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            // Eje horizontal - eje x (paralelo al ancho-width del picCanvas).
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
        }

        //Función para evaluar la función cuadrática.        
        public void EvaluateFunction(float m, float X1, float Y1,
            float xCenter, float yCenter)
        {
            float i; // Contador para controlar la función. // i - x
            int j;   // Contador para controlar el arreglo de puntos. // j - mP[j]: 21 ptos  
            // Dominio (x) de la función D:[-10, 10]
            // h = 1 // Tamaño de paso o delta x
            // i: -10, -9, -8,..., -1, 0, 1,..., 8, 9, 10
            // j: 0, 1, 2, 3,..., 18, 19, 20
            // mA = 1; mB = 1; mC = 1;
            // Cp(200,150)-Centro Trasladado
            // x:-10,-9,...,10
            // y: 91,73,..., 111
            // Fórmulas de Traslación Lineal de Ejes (Transformación-Matrices)
            // xp=x*SF+200; yp = (-1)*y*SF+150;
            // xp: 0,20,..., 400
            // yp: -1670,-1310,..., -2070
            // mP[0] = {0,-1670}
            // mP[1] = {20,-1310}
            // ...
            // mP[20] = {400, -2070}
            I1 = -30; I2 = 30;
            for (i = I1, j = 0; i <= I2; i++, j++)
            {
                // Tabla de valores del mundo real.
                mX = i; 
                mY = m * (mX - X1) + Y1; 
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + xCenter); 
                mYp = (float)((-1) * mY * SF + yCenter); 
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }

        // Función para graficar la curva.
        public void PlotLine(PictureBox picCanvas, float m, float X1, float Y1,
            float xCenter, float yCenter)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            // PointF - struct {X,Y}
            // Dominio: [-10,10]
            // -10,-9,...,-1,0,1,...,9,10
            // 10ptos+1pto+10ptos = 21 ptos
            mP = new PointF[61];

            EvaluateFunction(m, X1, Y1, xCenter, yCenter);
            // Teorema de existencia de una curva: Una curva cualquiera
            // se define con al menos tres puntos.
            // La función de DrawCurve internamente interpola datos.
            mGraph.DrawCurve(ObjPen, mP);
        }

        public void InitializeData()
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mX = 0.0f; mY = 0.0f; mXp = 0.0f; mYp = 0.0f;
        }

        public void InitializeControls(TextBox txtA, TextBox txtB, TextBox txtC,
                                       PictureBox picCanvas,
                                       ListBox lstX, ListBox lstY,
                                       ListBox lstXp, ListBox lstYp)
        {
            txtA.Text = ""; txtB.Text = ""; txtC.Text = "";
            picCanvas.Refresh();
            lstX.Items.Clear(); lstY.Items.Clear();
            lstXp.Items.Clear(); lstYp.Items.Clear();
        }

    }
}
