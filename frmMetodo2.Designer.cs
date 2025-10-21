namespace CSharp_2025
{
    partial class frmMetodo2
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
            this.lblExMetodo2 = new System.Windows.Forms.Label();
            this.txtMetro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblMetragem = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCalculadoraCusto = new System.Windows.Forms.Label();
            this.lblTotalRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExMetodo2
            // 
            this.lblExMetodo2.AutoSize = true;
            this.lblExMetodo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExMetodo2.Location = new System.Drawing.Point(12, 9);
            this.lblExMetodo2.Name = "lblExMetodo2";
            this.lblExMetodo2.Size = new System.Drawing.Size(344, 29);
            this.lblExMetodo2.TabIndex = 0;
            this.lblExMetodo2.Text = "Exercicio 2 - Aula 05 - Métodos";
            // 
            // txtMetro
            // 
            this.txtMetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetro.Location = new System.Drawing.Point(220, 163);
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(100, 34);
            this.txtMetro.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(350, 378);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 61);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(510, 378);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 61);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblMetragem
            // 
            this.lblMetragem.AutoSize = true;
            this.lblMetragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetragem.Location = new System.Drawing.Point(86, 166);
            this.lblMetragem.Name = "lblMetragem";
            this.lblMetragem.Size = new System.Drawing.Size(128, 29);
            this.lblMetragem.TabIndex = 4;
            this.lblMetragem.Text = "Metragem:";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(345, 166);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(191, 29);
            this.lblCusto.TabIndex = 6;
            this.lblCusto.Text = "Custo por Metro:";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Location = new System.Drawing.Point(542, 163);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 34);
            this.txtCusto.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(254, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 29);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblCalculadoraCusto
            // 
            this.lblCalculadoraCusto.AutoSize = true;
            this.lblCalculadoraCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadoraCusto.Location = new System.Drawing.Point(150, 82);
            this.lblCalculadoraCusto.Name = "lblCalculadoraCusto";
            this.lblCalculadoraCusto.Size = new System.Drawing.Size(376, 29);
            this.lblCalculadoraCusto.TabIndex = 9;
            this.lblCalculadoraCusto.Text = "CALCULADORA CUSTO TECIDO";
            // 
            // lblTotalRes
            // 
            this.lblTotalRes.AutoSize = true;
            this.lblTotalRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRes.Location = new System.Drawing.Point(334, 267);
            this.lblTotalRes.Name = "lblTotalRes";
            this.lblTotalRes.Size = new System.Drawing.Size(0, 29);
            this.lblTotalRes.TabIndex = 10;
            // 
            // frmMetodo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.lblTotalRes);
            this.Controls.Add(this.lblCalculadoraCusto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblMetragem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMetro);
            this.Controls.Add(this.lblExMetodo2);
            this.Name = "frmMetodo2";
            this.Text = "frmMetodo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExMetodo2;
        private System.Windows.Forms.TextBox txtMetro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMetragem;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCalculadoraCusto;
        private System.Windows.Forms.Label lblTotalRes;
    }
}