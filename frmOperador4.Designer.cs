namespace CSharp_2025
{
    partial class frmOperador4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperador4));
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCalculadoraIMC = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.pbAcima = new System.Windows.Forms.PictureBox();
            this.pbIdeal = new System.Windows.Forms.PictureBox();
            this.pbMagro = new System.Windows.Forms.PictureBox();
            this.pbObeso = new System.Windows.Forms.PictureBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObeso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(84, 78);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(209, 29);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Informe sua altura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 636);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 52);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(172, 636);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 52);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCalculadoraIMC
            // 
            this.lblCalculadoraIMC.AutoSize = true;
            this.lblCalculadoraIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadoraIMC.Location = new System.Drawing.Point(12, 9);
            this.lblCalculadoraIMC.Name = "lblCalculadoraIMC";
            this.lblCalculadoraIMC.Size = new System.Drawing.Size(550, 29);
            this.lblCalculadoraIMC.TabIndex = 4;
            this.lblCalculadoraIMC.Text = "Calculadora IMC - AULA 04 - Operadores Lógicos ";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(323, 133);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(153, 34);
            this.txtPeso.TabIndex = 2;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(88, 137);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(205, 29);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Informe seu peso:";
            // 
            // txtImc
            // 
            this.txtImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImc.Location = new System.Drawing.Point(323, 191);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(153, 34);
            this.txtImc.TabIndex = 8;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(231, 196);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(62, 29);
            this.lblIMC.TabIndex = 7;
            this.lblIMC.Text = "IMC:";
            // 
            // pbAcima
            // 
            this.pbAcima.Image = ((System.Drawing.Image)(resources.GetObject("pbAcima.Image")));
            this.pbAcima.Location = new System.Drawing.Point(155, 253);
            this.pbAcima.Name = "pbAcima";
            this.pbAcima.Size = new System.Drawing.Size(263, 340);
            this.pbAcima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcima.TabIndex = 9;
            this.pbAcima.TabStop = false;
            // 
            // pbIdeal
            // 
            this.pbIdeal.Image = ((System.Drawing.Image)(resources.GetObject("pbIdeal.Image")));
            this.pbIdeal.Location = new System.Drawing.Point(155, 253);
            this.pbIdeal.Name = "pbIdeal";
            this.pbIdeal.Size = new System.Drawing.Size(263, 340);
            this.pbIdeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIdeal.TabIndex = 10;
            this.pbIdeal.TabStop = false;
            // 
            // pbMagro
            // 
            this.pbMagro.Image = ((System.Drawing.Image)(resources.GetObject("pbMagro.Image")));
            this.pbMagro.Location = new System.Drawing.Point(155, 253);
            this.pbMagro.Name = "pbMagro";
            this.pbMagro.Size = new System.Drawing.Size(263, 340);
            this.pbMagro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMagro.TabIndex = 11;
            this.pbMagro.TabStop = false;
            // 
            // pbObeso
            // 
            this.pbObeso.Image = ((System.Drawing.Image)(resources.GetObject("pbObeso.Image")));
            this.pbObeso.Location = new System.Drawing.Point(155, 253);
            this.pbObeso.Name = "pbObeso";
            this.pbObeso.Size = new System.Drawing.Size(263, 340);
            this.pbObeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbObeso.TabIndex = 12;
            this.pbObeso.TabStop = false;
            // 
            // txtAlt
            // 
            this.txtAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlt.Location = new System.Drawing.Point(323, 75);
            this.txtAlt.MaxLength = 3;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(153, 34);
            this.txtAlt.TabIndex = 1;
            // 
            // frmOperador4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 700);
            this.Controls.Add(this.pbObeso);
            this.Controls.Add(this.pbMagro);
            this.Controls.Add(this.pbIdeal);
            this.Controls.Add(this.pbAcima);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCalculadoraIMC);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.lblAltura);
            this.Name = "frmOperador4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOperador4";
            this.Load += new System.EventHandler(this.frmOperador4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAcima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCalculadoraIMC;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.PictureBox pbAcima;
        private System.Windows.Forms.PictureBox pbIdeal;
        private System.Windows.Forms.PictureBox pbMagro;
        private System.Windows.Forms.PictureBox pbObeso;
        private System.Windows.Forms.TextBox txtAlt;
    }
}