namespace StarryPolygon
{
    partial class Form1
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
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbCanvas.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(319, 30);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(672, 514);
            this.grbCanvas.TabIndex = 0;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            this.grbCanvas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtSide);
            this.grbInput.Controls.Add(this.lblSide);
            this.grbInput.Location = new System.Drawing.Point(20, 93);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(260, 86);
            this.grbInput.TabIndex = 1;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entrada";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Location = new System.Drawing.Point(20, 270);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(260, 203);
            this.grbProcess.TabIndex = 2;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(19, 36);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(45, 13);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Medida:";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(81, 33);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(120, 20);
            this.txtSide.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(81, 98);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(81, 44);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Graficar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(32, 24);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(603, 459);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 575);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbCanvas.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

