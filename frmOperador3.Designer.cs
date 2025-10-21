namespace CSharp_2025
{
    partial class frmOperador3
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
            this.lblSalAtual = new System.Windows.Forms.Label();
            this.txtSalAtual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPorcAumento = new System.Windows.Forms.Label();
            this.txtPorc = new System.Windows.Forms.TextBox();
            this.lblSalAtualizado = new System.Windows.Forms.Label();
            this.txtSalAtualizado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.lblNivel4 = new System.Windows.Forms.Label();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.lblNivel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalAtual
            // 
            this.lblSalAtual.AutoSize = true;
            this.lblSalAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalAtual.Location = new System.Drawing.Point(36, 91);
            this.lblSalAtual.Name = "lblSalAtual";
            this.lblSalAtual.Size = new System.Drawing.Size(154, 29);
            this.lblSalAtual.TabIndex = 0;
            this.lblSalAtual.Text = "Salario Atual:";
            // 
            // txtSalAtual
            // 
            this.txtSalAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalAtual.Location = new System.Drawing.Point(196, 88);
            this.txtSalAtual.Name = "txtSalAtual";
            this.txtSalAtual.Size = new System.Drawing.Size(158, 34);
            this.txtSalAtual.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(15, 376);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 62);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(217, 376);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 62);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPorcAumento
            // 
            this.lblPorcAumento.AutoSize = true;
            this.lblPorcAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcAumento.Location = new System.Drawing.Point(393, 91);
            this.lblPorcAumento.Name = "lblPorcAumento";
            this.lblPorcAumento.Size = new System.Drawing.Size(142, 29);
            this.lblPorcAumento.TabIndex = 0;
            this.lblPorcAumento.Text = "Aumento %:";
            // 
            // txtPorc
            // 
            this.txtPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorc.Location = new System.Drawing.Point(541, 88);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(158, 34);
            this.txtPorc.TabIndex = 1;
            // 
            // lblSalAtualizado
            // 
            this.lblSalAtualizado.AutoSize = true;
            this.lblSalAtualizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalAtualizado.Location = new System.Drawing.Point(36, 172);
            this.lblSalAtualizado.Name = "lblSalAtualizado";
            this.lblSalAtualizado.Size = new System.Drawing.Size(212, 29);
            this.lblSalAtualizado.TabIndex = 0;
            this.lblSalAtualizado.Text = "Salario Atualizado:";
            // 
            // txtSalAtualizado
            // 
            this.txtSalAtualizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalAtualizado.Location = new System.Drawing.Point(263, 169);
            this.txtSalAtualizado.Name = "txtSalAtualizado";
            this.txtSalAtualizado.ReadOnly = true;
            this.txtSalAtualizado.Size = new System.Drawing.Size(160, 34);
            this.txtSalAtualizado.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calculadora de Aumento Salarial";
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel1.Location = new System.Drawing.Point(323, 279);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(188, 29);
            this.lblNivel1.TabIndex = 5;
            this.lblNivel1.Text = "Aumento Nível 1";
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel2.Location = new System.Drawing.Point(323, 279);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(188, 29);
            this.lblNivel2.TabIndex = 6;
            this.lblNivel2.Text = "Aumento Nível 2";
            // 
            // lblNivel4
            // 
            this.lblNivel4.AutoSize = true;
            this.lblNivel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel4.Location = new System.Drawing.Point(323, 279);
            this.lblNivel4.Name = "lblNivel4";
            this.lblNivel4.Size = new System.Drawing.Size(188, 29);
            this.lblNivel4.TabIndex = 7;
            this.lblNivel4.Text = "Aumento Nível 4";
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel3.Location = new System.Drawing.Point(323, 279);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(188, 29);
            this.lblNivel3.TabIndex = 8;
            this.lblNivel3.Text = "Aumento Nível 3";
            // 
            // lblNivel5
            // 
            this.lblNivel5.AutoSize = true;
            this.lblNivel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel5.Location = new System.Drawing.Point(323, 279);
            this.lblNivel5.Name = "lblNivel5";
            this.lblNivel5.Size = new System.Drawing.Size(188, 29);
            this.lblNivel5.TabIndex = 9;
            this.lblNivel5.Text = "Aumento Nível 5";
            // 
            // frmOperador3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNivel5);
            this.Controls.Add(this.lblNivel3);
            this.Controls.Add(this.lblNivel4);
            this.Controls.Add(this.lblNivel2);
            this.Controls.Add(this.lblNivel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalAtualizado);
            this.Controls.Add(this.txtPorc);
            this.Controls.Add(this.txtSalAtual);
            this.Controls.Add(this.lblSalAtualizado);
            this.Controls.Add(this.lblPorcAumento);
            this.Controls.Add(this.lblSalAtual);
            this.Name = "frmOperador3";
            this.Text = "frmOperador3";
            this.Load += new System.EventHandler(this.frmOperador3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalAtual;
        private System.Windows.Forms.TextBox txtSalAtual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPorcAumento;
        private System.Windows.Forms.TextBox txtPorc;
        private System.Windows.Forms.Label lblSalAtualizado;
        private System.Windows.Forms.TextBox txtSalAtualizado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Label lblNivel2;
        private System.Windows.Forms.Label lblNivel4;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.Label lblNivel5;
    }
}