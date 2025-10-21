namespace CSharp_2025
{
    partial class frmOperador5
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
            this.lblEx5 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSalAtual = new System.Windows.Forms.Label();
            this.lblAumento15 = new System.Windows.Forms.Label();
            this.txtAumento15 = new System.Windows.Forms.TextBox();
            this.lblAumento18 = new System.Windows.Forms.Label();
            this.txtAumento18 = new System.Windows.Forms.TextBox();
            this.lblSalAtualizado = new System.Windows.Forms.Label();
            this.txtSalAtual = new System.Windows.Forms.TextBox();
            this.lblTotalAumento = new System.Windows.Forms.Label();
            this.txtTotalAumento = new System.Windows.Forms.TextBox();
            this.lblRuim = new System.Windows.Forms.Label();
            this.lblRazoavel = new System.Windows.Forms.Label();
            this.lblBom = new System.Windows.Forms.Label();
            this.lblOtimo = new System.Windows.Forms.Label();
            this.lblExcelente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEx5
            // 
            this.lblEx5.AutoSize = true;
            this.lblEx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEx5.Location = new System.Drawing.Point(12, 9);
            this.lblEx5.Name = "lblEx5";
            this.lblEx5.Size = new System.Drawing.Size(472, 29);
            this.lblEx5.TabIndex = 0;
            this.lblEx5.Text = "Exercicio 5 - Aula 04 - Aumento Salarial";
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(288, 75);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(159, 34);
            this.txtSal.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(500, 441);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(647, 441);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(141, 46);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSalAtual
            // 
            this.lblSalAtual.AutoSize = true;
            this.lblSalAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalAtual.Location = new System.Drawing.Point(82, 76);
            this.lblSalAtual.Name = "lblSalAtual";
            this.lblSalAtual.Size = new System.Drawing.Size(190, 29);
            this.lblSalAtual.TabIndex = 4;
            this.lblSalAtual.Text = "Salario Atual: R$";
            // 
            // lblAumento15
            // 
            this.lblAumento15.AutoSize = true;
            this.lblAumento15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumento15.Location = new System.Drawing.Point(68, 136);
            this.lblAumento15.Name = "lblAumento15";
            this.lblAumento15.Size = new System.Drawing.Size(204, 29);
            this.lblAumento15.TabIndex = 6;
            this.lblAumento15.Text = "Aumento 15%: R$";
            // 
            // txtAumento15
            // 
            this.txtAumento15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento15.Location = new System.Drawing.Point(288, 133);
            this.txtAumento15.Name = "txtAumento15";
            this.txtAumento15.ReadOnly = true;
            this.txtAumento15.Size = new System.Drawing.Size(159, 34);
            this.txtAumento15.TabIndex = 5;
            // 
            // lblAumento18
            // 
            this.lblAumento18.AutoSize = true;
            this.lblAumento18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumento18.Location = new System.Drawing.Point(68, 187);
            this.lblAumento18.Name = "lblAumento18";
            this.lblAumento18.Size = new System.Drawing.Size(204, 29);
            this.lblAumento18.TabIndex = 8;
            this.lblAumento18.Text = "Aumento 18%: R$";
            // 
            // txtAumento18
            // 
            this.txtAumento18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento18.Location = new System.Drawing.Point(288, 184);
            this.txtAumento18.Name = "txtAumento18";
            this.txtAumento18.ReadOnly = true;
            this.txtAumento18.Size = new System.Drawing.Size(159, 34);
            this.txtAumento18.TabIndex = 7;
            // 
            // lblSalAtualizado
            // 
            this.lblSalAtualizado.AutoSize = true;
            this.lblSalAtualizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalAtualizado.Location = new System.Drawing.Point(24, 249);
            this.lblSalAtualizado.Name = "lblSalAtualizado";
            this.lblSalAtualizado.Size = new System.Drawing.Size(248, 29);
            this.lblSalAtualizado.TabIndex = 10;
            this.lblSalAtualizado.Text = "Salario Atualizado: R$";
            // 
            // txtSalAtual
            // 
            this.txtSalAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalAtual.Location = new System.Drawing.Point(288, 246);
            this.txtSalAtual.Name = "txtSalAtual";
            this.txtSalAtual.ReadOnly = true;
            this.txtSalAtual.Size = new System.Drawing.Size(159, 34);
            this.txtSalAtual.TabIndex = 9;
            // 
            // lblTotalAumento
            // 
            this.lblTotalAumento.AutoSize = true;
            this.lblTotalAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAumento.Location = new System.Drawing.Point(61, 306);
            this.lblTotalAumento.Name = "lblTotalAumento";
            this.lblTotalAumento.Size = new System.Drawing.Size(211, 29);
            this.lblTotalAumento.TabIndex = 12;
            this.lblTotalAumento.Text = "Total Aumento: R$";
            // 
            // txtTotalAumento
            // 
            this.txtTotalAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAumento.Location = new System.Drawing.Point(288, 303);
            this.txtTotalAumento.Name = "txtTotalAumento";
            this.txtTotalAumento.ReadOnly = true;
            this.txtTotalAumento.Size = new System.Drawing.Size(159, 34);
            this.txtTotalAumento.TabIndex = 11;
            // 
            // lblRuim
            // 
            this.lblRuim.AutoSize = true;
            this.lblRuim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuim.Location = new System.Drawing.Point(325, 382);
            this.lblRuim.Name = "lblRuim";
            this.lblRuim.Size = new System.Drawing.Size(186, 29);
            this.lblRuim.TabIndex = 13;
            this.lblRuim.Text = "Aumento RUIM";
            // 
            // lblRazoavel
            // 
            this.lblRazoavel.AutoSize = true;
            this.lblRazoavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazoavel.Location = new System.Drawing.Point(293, 382);
            this.lblRazoavel.Name = "lblRazoavel";
            this.lblRazoavel.Size = new System.Drawing.Size(254, 29);
            this.lblRazoavel.TabIndex = 14;
            this.lblRazoavel.Text = "Aumento RAZOÁVEL";
            // 
            // lblBom
            // 
            this.lblBom.AutoSize = true;
            this.lblBom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBom.Location = new System.Drawing.Point(328, 382);
            this.lblBom.Name = "lblBom";
            this.lblBom.Size = new System.Drawing.Size(180, 29);
            this.lblBom.TabIndex = 15;
            this.lblBom.Text = "Aumento BOM";
            // 
            // lblOtimo
            // 
            this.lblOtimo.AutoSize = true;
            this.lblOtimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtimo.Location = new System.Drawing.Point(315, 382);
            this.lblOtimo.Name = "lblOtimo";
            this.lblOtimo.Size = new System.Drawing.Size(207, 29);
            this.lblOtimo.TabIndex = 16;
            this.lblOtimo.Text = "Aumento ÓTIMO";
            // 
            // lblExcelente
            // 
            this.lblExcelente.AutoSize = true;
            this.lblExcelente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcelente.Location = new System.Drawing.Point(283, 382);
            this.lblExcelente.Name = "lblExcelente";
            this.lblExcelente.Size = new System.Drawing.Size(276, 29);
            this.lblExcelente.TabIndex = 17;
            this.lblExcelente.Text = "Aumento EXCELENTE";
            // 
            // frmOperador5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lblExcelente);
            this.Controls.Add(this.lblOtimo);
            this.Controls.Add(this.lblBom);
            this.Controls.Add(this.lblRazoavel);
            this.Controls.Add(this.lblRuim);
            this.Controls.Add(this.lblTotalAumento);
            this.Controls.Add(this.txtTotalAumento);
            this.Controls.Add(this.lblSalAtualizado);
            this.Controls.Add(this.txtSalAtual);
            this.Controls.Add(this.lblAumento18);
            this.Controls.Add(this.txtAumento18);
            this.Controls.Add(this.lblAumento15);
            this.Controls.Add(this.txtAumento15);
            this.Controls.Add(this.lblSalAtual);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblEx5);
            this.Name = "frmOperador5";
            this.Text = "frmOperador5";
            this.Load += new System.EventHandler(this.frmOperador5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEx5;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSalAtual;
        private System.Windows.Forms.Label lblAumento15;
        private System.Windows.Forms.TextBox txtAumento15;
        private System.Windows.Forms.Label lblAumento18;
        private System.Windows.Forms.TextBox txtAumento18;
        private System.Windows.Forms.Label lblSalAtualizado;
        private System.Windows.Forms.TextBox txtSalAtual;
        private System.Windows.Forms.Label lblTotalAumento;
        private System.Windows.Forms.TextBox txtTotalAumento;
        private System.Windows.Forms.Label lblRuim;
        private System.Windows.Forms.Label lblRazoavel;
        private System.Windows.Forms.Label lblBom;
        private System.Windows.Forms.Label lblOtimo;
        private System.Windows.Forms.Label lblExcelente;
    }
}