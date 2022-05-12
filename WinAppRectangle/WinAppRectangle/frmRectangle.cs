﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppRectangle
{
    public partial class FrmRectangle : Form
    {
        private CRectangle ObjRectangle = new CRectangle();


        public FrmRectangle()
        {
            InitializeComponent();
        }



        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjRectangle.InitializeData(txtWidth, txtHeight,
            txtPerimeter, txtArea,
            picCanvas,trackBarXCoord.Value,trackBarYCoord.Value);
            
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Lectura de datos.
            // Llamada a la función ReadData.
            ObjRectangle.ReadData(txtWidth, txtHeight);
            // Cálculo del perímetro de un rectángulo.
            // Llamada a la función PerimeterRectangle.
            ObjRectangle.PerimeterRectangle();
            // Cálculo del área de un rectángulo.
            // Llamada a la función AreaRectangle.
            ObjRectangle.AreaRectangle();
            // Impresión de datos.
            // Llamada a la función PrintData.
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            // Graficación de un rectángulo.
            // Llamada a la función PlotShape.
            ObjRectangle.PlotShape(picCanvas);
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjRectangle.InitializeData(txtWidth, txtHeight,
            txtPerimeter, txtArea,
            picCanvas, trackBarXCoord.Value, trackBarYCoord.Value);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            ObjRectangle.CloseForm(this);
            
        }

        private void trackBarLargo_Scroll(object sender, EventArgs e)
        {
            trackBar_Scroll();
        }

        private void trackBar_Scroll()
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight,
            txtPerimeter, txtArea,
            picCanvas, trackBarXCoord.Value, trackBarYCoord.Value);
            // Lectura de datos.
            // Llamada a la función ReadData.
            ObjRectangle.ReadDataTrackBar(trackBarAncho.Value.ToString(),
            trackBarLargo.Value.ToString());
            // Cálculo del perímetro de un rectángulo.
            // Llamada a la función PerimeterRectangle.
            ObjRectangle.PerimeterRectangle();
            // Cálculo del área de un rectángulo.
            // Llamada a la función AreaRectangle.
            ObjRectangle.AreaRectangle();
            // Impresión de datos.
            // Llamada a la función PrintData.
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            // Graficación de un rectángulo.
            // Llamada a la función PlotShape.
            ObjRectangle.PlotShape(picCanvas);
        }

        private void trackBarXCoord_Scroll(object sender, EventArgs e)
        {
            ObjRectangle.setCoords(trackBarXCoord.Value, trackBarYCoord.Value);
            trackBar_Scroll();
        }

        private void trackBarYCoord_Scroll(object sender, EventArgs e)
        {
            ObjRectangle.setCoords(trackBarXCoord.Value, trackBarYCoord.Value);
            trackBar_Scroll();
        }

        private void trackBarAncho_Scroll(object sender, EventArgs e)
        {
            trackBar_Scroll();
        }
    }
}
