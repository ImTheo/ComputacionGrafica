﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPPTetris
{
    class CTetris
    {
        // Objeto que activa el modo gráfico.
        private Graphics mGraphF;
        // Constante scale factor (Zoom In/Zoom Out)
        private const int SF = 20;
        // Objeto pluma que dibuja o escribe en un lienzo.
        private Pen mPen;
        // 
        int x = 30, y = 10;
        public CTetris()
        {

        }
        public void InititializeData()
        {
            x = 30;
            y = 10;
        }
        public void GraphPause(PictureBox picCanvas)
        {
            mGraphF = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);
            Pen mPenBlue = new Pen(Color.CadetBlue, 2);
            SolidBrush cBlueBrush = new SolidBrush(Color.CadetBlue);
            var font = new Font("TimesNewRoman", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            mGraphF.DrawRectangle(mPenBlue, 0, 0, 8 * SF, 2 * SF);
            mGraphF.DrawString("Pause", font, cBlueBrush, 1.5f * SF, 0);

        }
        public void GraphExit(PictureBox picCanvas)
        {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            var font = new Font("TimesNewRoman", 20, FontStyle.Bold);
            mPen = new Pen(Color.Black, 2);
            Graphics mGraphExit = picCanvas.CreateGraphics();
            mGraphExit.DrawRectangle(mPen, 0, 0, 5 * SF, 2 * SF);
            mGraphExit.DrawString("QUIT", font, blackBrush, SF-10, 0);

        }
        public void GraphMainArea(PictureBox picCanvas)
        {
            mGraphF = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);
            SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            mGraphF.DrawRectangle(mPen, x, y, 10 * SF, 20 * SF);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Rectangle upperGreenPiece = new Rectangle(x + (4 + i) * SF, y + (2 + j) * SF, 1 * SF, 1 * SF);
                    mGraphF.DrawRectangle(mPen, upperGreenPiece);
                    mGraphF.FillRectangle(greenBrush, upperGreenPiece);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Rectangle lowerYellowPiece = new Rectangle(x + (7 + i) * SF, (int)(y + (20 - 2.05 + j) * SF), 1 * SF, 1 * SF);
                    mGraphF.DrawRectangle(mPen, lowerYellowPiece);
                    mGraphF.FillRectangle(yellowBrush, lowerYellowPiece);
                    if (i == 1)
                    {
                        Rectangle lowerYellowPiece2 = new Rectangle((int)(x + (5.95) * SF), (int)(y + (18.95) * SF), 1 * SF, 1 * SF);
                        mGraphF.DrawRectangle(mPen, lowerYellowPiece2);
                        mGraphF.FillRectangle(yellowBrush, lowerYellowPiece2);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Rectangle lowerBluePiece = new Rectangle(x + (9) * SF, y + (20 - 3 + i) * SF, 1 * SF, 1 * SF);
                mGraphF.DrawRectangle(mPen, lowerBluePiece);
                mGraphF.FillRectangle(blueBrush, lowerBluePiece);
                if (i == 1)
                {
                    Rectangle lowerBluePiece2 = new Rectangle(x + (8) * SF, y + (19) * SF, 1 * SF, 1 * SF);
                    mGraphF.DrawRectangle(mPen, lowerBluePiece2);
                    mGraphF.FillRectangle(blueBrush, lowerBluePiece2);
                }
            }
        }
        public void GraphNextArea(PictureBox picCanvas)
        {
            mGraphF = picCanvas.CreateGraphics();
            x = x + 12 * SF;
            mPen = new Pen(Color.Black, 2);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            mGraphF.DrawRectangle(mPen, x, y, 7 * SF, 4 * SF);
            var font = new Font("TimesNewRoman", 17, FontStyle.Bold, GraphicsUnit.Pixel);

            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    Rectangle NextPiece = new Rectangle(x + (4) * SF, y + (1 + j) * SF, 1 * SF, 1 * SF);
                    mGraphF.DrawRectangle(mPen, NextPiece);
                    mGraphF.FillRectangle(redBrush, NextPiece);
                }

                if (j == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Rectangle NextPiece2 = new Rectangle(x + (2 + i) * SF, y + (1 + j) * SF, 1 * SF, 1 * SF);
                        mGraphF.DrawRectangle(mPen, NextPiece2);
                        mGraphF.FillRectangle(redBrush, NextPiece2);
                    }
                }

            }

            //Info
            mGraphF.DrawString("Level:   1", font, blackBrush, x, y + 6 * SF);
            mGraphF.DrawString("Lines:   0", font, blackBrush, x, y + 8 * SF);
            mGraphF.DrawString("Score:   0", font, blackBrush, x, y + 10 * SF);


        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
        public void RefreshPause(PictureBox picCanvas)
        {
            picCanvas.Refresh();
        }
    }
}
