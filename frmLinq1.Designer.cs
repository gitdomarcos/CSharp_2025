namespace CSharp_2025
{
    partial class frmLinq1
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
            this.lblNumeroCalcado = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbMarcaPesquisa = new System.Windows.Forms.ComboBox();
            this.listBoxNike = new System.Windows.Forms.ListBox();
            this.txtNumCalcado = new System.Windows.Forms.TextBox();
            this.cbMarcaAdd = new System.Windows.Forms.ComboBox();
            this.lblSelecionarMarca = new System.Windows.Forms.Label();
            this.listBoxAdidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNumPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDirecao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroCalcado
            // 
            this.lblNumeroCalcado.AutoSize = true;
            this.lblNumeroCalcado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCalcado.Location = new System.Drawing.Point(20, 51);
            this.lblNumeroCalcado.Name = "lblNumeroCalcado";
            this.lblNumeroCalcado.Size = new System.Drawing.Size(293, 29);
            this.lblNumeroCalcado.TabIndex = 0;
            this.lblNumeroCalcado.Text = "Informe número calçado:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(23, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbMarcaPesquisa
            // 
            this.cbMarcaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaPesquisa.FormattingEnabled = true;
            this.cbMarcaPesquisa.Items.AddRange(new object[] {
            "ADIDAS",
            "NIKE"});
            this.cbMarcaPesquisa.Location = new System.Drawing.Point(29, 91);
            this.cbMarcaPesquisa.Name = "cbMarcaPesquisa";
            this.cbMarcaPesquisa.Size = new System.Drawing.Size(226, 37);
            this.cbMarcaPesquisa.TabIndex = 2;
            // 
            // listBoxNike
            // 
            this.listBoxNike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNike.FormattingEnabled = true;
            this.listBoxNike.ItemHeight = 29;
            this.listBoxNike.Location = new System.Drawing.Point(35, 275);
            this.listBoxNike.Name = "listBoxNike";
            this.listBoxNike.Size = new System.Drawing.Size(298, 323);
            this.listBoxNike.TabIndex = 3;
            // 
            // txtNumCalcado
            // 
            this.txtNumCalcado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCalcado.Location = new System.Drawing.Point(25, 92);
            this.txtNumCalcado.Name = "txtNumCalcado";
            this.txtNumCalcado.Size = new System.Drawing.Size(288, 36);
            this.txtNumCalcado.TabIndex = 5;
            // 
            // cbMarcaAdd
            // 
            this.cbMarcaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaAdd.FormattingEnabled = true;
            this.cbMarcaAdd.Items.AddRange(new object[] {
            "ADIDAS",
            "NIKE"});
            this.cbMarcaAdd.Location = new System.Drawing.Point(359, 92);
            this.cbMarcaAdd.Name = "cbMarcaAdd";
            this.cbMarcaAdd.Size = new System.Drawing.Size(288, 37);
            this.cbMarcaAdd.TabIndex = 6;
            // 
            // lblSelecionarMarca
            // 
            this.lblSelecionarMarca.AutoSize = true;
            this.lblSelecionarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarMarca.Location = new System.Drawing.Point(364, 51);
            this.lblSelecionarMarca.Name = "lblSelecionarMarca";
            this.lblSelecionarMarca.Size = new System.Drawing.Size(231, 29);
            this.lblSelecionarMarca.TabIndex = 7;
            this.lblSelecionarMarca.Text = "Selecione a marca:";
            // 
            // listBoxAdidas
            // 
            this.listBoxAdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAdidas.FormattingEnabled = true;
            this.listBoxAdidas.ItemHeight = 29;
            this.listBoxAdidas.Location = new System.Drawing.Point(342, 275);
            this.listBoxAdidas.Name = "listBoxAdidas";
            this.listBoxAdidas.Size = new System.Drawing.Size(298, 323);
            this.listBoxAdidas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione a marca:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(29, 353);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(192, 54);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNumPesquisa
            // 
            this.txtNumPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPesquisa.Location = new System.Drawing.Point(29, 198);
            this.txtNumPesquisa.Name = "txtNumPesquisa";
            this.txtNumPesquisa.Size = new System.Drawing.Size(226, 36);
            this.txtNumPesquisa.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informe o tamanho:";
            // 
            // cbDirecao
            // 
            this.cbDirecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDirecao.FormattingEnabled = true;
            this.cbDirecao.Items.AddRange(new object[] {
            "ACIMA",
            "ABAIXO",
            "IGUAL"});
            this.cbDirecao.Location = new System.Drawing.Point(29, 258);
            this.cbDirecao.Name = "cbDirecao";
            this.cbDirecao.Size = new System.Drawing.Size(226, 37);
            this.cbDirecao.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nike";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(227, 163);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(192, 54);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.listBoxAdidas);
            this.groupBox2.Controls.Add(this.lblSelecionarMarca);
            this.groupBox2.Controls.Add(this.cbMarcaAdd);
            this.groupBox2.Controls.Add(this.txtNumCalcado);
            this.groupBox2.Controls.Add(this.listBoxNike);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lblNumeroCalcado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 620);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro Marca e Tamanho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDirecao);
            this.groupBox1.Controls.Add(this.txtNumPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMarcaPesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(693, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 619);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // frmLinq1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLinq1";
            this.Text = "frmLinq1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCalcado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMarcaPesquisa;
        private System.Windows.Forms.ListBox listBoxNike;
        private System.Windows.Forms.TextBox txtNumCalcado;
        private System.Windows.Forms.ComboBox cbMarcaAdd;
        private System.Windows.Forms.Label lblSelecionarMarca;
        private System.Windows.Forms.ListBox listBoxAdidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNumPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDirecao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}