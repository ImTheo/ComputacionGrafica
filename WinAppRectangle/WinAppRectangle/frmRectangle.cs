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
    public partial class frmRectangle : Form
    {
        private CRectangle ObjRectangle = new CRectangle();


        public frmRectangle()
        {
            InitializeComponent();
        }



        private void frmRectangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjRectangle.InitializeData(txtWidth, txtHeight,
            txtPerimeter, txtArea,
            picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
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

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjRectangle.InitializeData(txtWidth, txtHeight,
            txtPerimeter, txtArea,
           picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            ObjRectangle.CloseForm(this);
            
        }
    }
}
