namespace WinAppTriangle
{
    partial class frmTriangle
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.lblSideC = new System.Windows.Forms.Label();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblSideA = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.trackBarLadoA = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarLadoB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarLadoC = new System.Windows.Forms.TrackBar();
            this.grbProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbOutputs.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoC)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(12, 119);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(2);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(2);
            this.grbProcess.Size = new System.Drawing.Size(212, 58);
            this.grbProcess.TabIndex = 15;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 17);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(84, 17);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 25);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 17);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(66, 25);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(4, 17);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(375, 241);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Location = new System.Drawing.Point(11, 182);
            this.grbOutputs.Margin = new System.Windows.Forms.Padding(2);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Padding = new System.Windows.Forms.Padding(2);
            this.grbOutputs.Size = new System.Drawing.Size(212, 92);
            this.grbOutputs.TabIndex = 17;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(95, 47);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(95, 18);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(76, 20);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(14, 51);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(14, 22);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(56, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(95, 23);
            this.txtSideA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(76, 20);
            this.txtSideA.TabIndex = 1;
            this.txtSideA.Text = "0";
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.lblSideC);
            this.grbInputs.Controls.Add(this.txtSideC);
            this.grbInputs.Controls.Add(this.lblSideB);
            this.grbInputs.Controls.Add(this.txtSideB);
            this.grbInputs.Controls.Add(this.txtSideA);
            this.grbInputs.Controls.Add(this.lblSideA);
            this.grbInputs.Location = new System.Drawing.Point(11, 11);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(2);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(2);
            this.grbInputs.Size = new System.Drawing.Size(212, 104);
            this.grbInputs.TabIndex = 16;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(11, 72);
            this.lblSideC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(43, 13);
            this.lblSideC.TabIndex = 5;
            this.lblSideC.Text = "Lado c:";
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(95, 68);
            this.txtSideC.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(76, 20);
            this.txtSideC.TabIndex = 4;
            this.txtSideC.Text = "0";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(11, 50);
            this.lblSideB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(43, 13);
            this.lblSideB.TabIndex = 3;
            this.lblSideB.Text = "Lado b:";
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(95, 46);
            this.txtSideB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(76, 20);
            this.txtSideB.TabIndex = 2;
            this.txtSideB.Text = "0";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(11, 27);
            this.lblSideA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(43, 13);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Lado a:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(227, 11);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(2);
            this.grbCanvas.Size = new System.Drawing.Size(388, 263);
            this.grbCanvas.TabIndex = 18;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // trackBarLadoA
            // 
            this.trackBarLadoA.Location = new System.Drawing.Point(231, 293);
            this.trackBarLadoA.Maximum = 100;
            this.trackBarLadoA.Name = "trackBarLadoA";
            this.trackBarLadoA.Size = new System.Drawing.Size(104, 45);
            this.trackBarLadoA.TabIndex = 19;
            this.trackBarLadoA.Scroll += new System.EventHandler(this.trackBarLadoA_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lado a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lado B";
            // 
            // trackBarLadoB
            // 
            this.trackBarLadoB.Location = new System.Drawing.Point(341, 293);
            this.trackBarLadoB.Maximum = 100;
            this.trackBarLadoB.Name = "trackBarLadoB";
            this.trackBarLadoB.Size = new System.Drawing.Size(104, 45);
            this.trackBarLadoB.TabIndex = 21;
            this.trackBarLadoB.Scroll += new System.EventHandler(this.trackBarLadoB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lado C";
            // 
            // trackBarLadoC
            // 
            this.trackBarLadoC.Location = new System.Drawing.Point(451, 293);
            this.trackBarLadoC.Maximum = 100;
            this.trackBarLadoC.Name = "trackBarLadoC";
            this.trackBarLadoC.Size = new System.Drawing.Size(104, 45);
            this.trackBarLadoC.TabIndex = 23;
            this.trackBarLadoC.Scroll += new System.EventHandler(this.trackBarLadoC_Scroll);
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarLadoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarLadoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarLadoA);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.grbCanvas);
            this.Name = "frmTriangle";
            this.Text = "Triángulo";
            this.Load += new System.EventHandler(this.frmTriangle_Load);
            this.grbProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLadoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.TrackBar trackBarLadoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarLadoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarLadoC;
    }
}

