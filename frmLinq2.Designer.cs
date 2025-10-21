namespace CSharp_2025
{
    partial class frmLinq2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.cbGeneroAdd = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.gbLivros = new System.Windows.Forms.GroupBox();
            this.listBoxRomance = new System.Windows.Forms.ListBox();
            this.listBoxNaoFiccao = new System.Windows.Forms.ListBox();
            this.listBoxFiccao = new System.Windows.Forms.ListBox();
            this.lblRomance = new System.Windows.Forms.Label();
            this.lblNaoFiccao = new System.Windows.Forms.Label();
            this.lblFiccao = new System.Windows.Forms.Label();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblGeneroPesq = new System.Windows.Forms.Label();
            this.cbGeneroPesq = new System.Windows.Forms.ComboBox();
            this.lblPagPesq = new System.Windows.Forms.Label();
            this.txtPagPesq = new System.Windows.Forms.TextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.cbPosicao = new System.Windows.Forms.ComboBox();
            this.gbCadastro.SuspendLayout();
            this.gbLivros.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq - Exercicio 2";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(26, 112);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(238, 29);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Selecione o gênero:";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.cbGeneroAdd);
            this.gbCadastro.Controls.Add(this.btnLimpar);
            this.gbCadastro.Controls.Add(this.btnAdd);
            this.gbCadastro.Controls.Add(this.lblGenero);
            this.gbCadastro.Controls.Add(this.txtPaginas);
            this.gbCadastro.Controls.Add(this.lblPaginas);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(17, 51);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(576, 295);
            this.gbCadastro.TabIndex = 5;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro livros";
            // 
            // cbGeneroAdd
            // 
            this.cbGeneroAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroAdd.FormattingEnabled = true;
            this.cbGeneroAdd.Items.AddRange(new object[] {
            "FICÇÃO",
            "NAO-FIXCÇÃO",
            "ROMANCE"});
            this.cbGeneroAdd.Location = new System.Drawing.Point(270, 108);
            this.cbGeneroAdd.Name = "cbGeneroAdd";
            this.cbGeneroAdd.Size = new System.Drawing.Size(296, 37);
            this.cbGeneroAdd.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(297, 198);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Location = new System.Drawing.Point(113, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(421, 41);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(145, 36);
            this.txtPaginas.TabIndex = 3;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(26, 45);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(389, 29);
            this.lblPaginas.TabIndex = 1;
            this.lblPaginas.Text = "Informe a quantidade de paginas:";
            // 
            // gbLivros
            // 
            this.gbLivros.Controls.Add(this.listBoxRomance);
            this.gbLivros.Controls.Add(this.listBoxNaoFiccao);
            this.gbLivros.Controls.Add(this.listBoxFiccao);
            this.gbLivros.Controls.Add(this.lblRomance);
            this.gbLivros.Controls.Add(this.lblNaoFiccao);
            this.gbLivros.Controls.Add(this.lblFiccao);
            this.gbLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLivros.Location = new System.Drawing.Point(17, 352);
            this.gbLivros.Name = "gbLivros";
            this.gbLivros.Size = new System.Drawing.Size(1030, 382);
            this.gbLivros.TabIndex = 6;
            this.gbLivros.TabStop = false;
            this.gbLivros.Text = "Livros Cadastrados";
            // 
            // listBoxRomance
            // 
            this.listBoxRomance.FormattingEnabled = true;
            this.listBoxRomance.ItemHeight = 29;
            this.listBoxRomance.Location = new System.Drawing.Point(687, 104);
            this.listBoxRomance.Name = "listBoxRomance";
            this.listBoxRomance.Size = new System.Drawing.Size(309, 265);
            this.listBoxRomance.TabIndex = 2;
            // 
            // listBoxNaoFiccao
            // 
            this.listBoxNaoFiccao.FormattingEnabled = true;
            this.listBoxNaoFiccao.ItemHeight = 29;
            this.listBoxNaoFiccao.Location = new System.Drawing.Point(352, 104);
            this.listBoxNaoFiccao.Name = "listBoxNaoFiccao";
            this.listBoxNaoFiccao.Size = new System.Drawing.Size(309, 265);
            this.listBoxNaoFiccao.TabIndex = 1;
            // 
            // listBoxFiccao
            // 
            this.listBoxFiccao.FormattingEnabled = true;
            this.listBoxFiccao.ItemHeight = 29;
            this.listBoxFiccao.Location = new System.Drawing.Point(18, 104);
            this.listBoxFiccao.Name = "listBoxFiccao";
            this.listBoxFiccao.Size = new System.Drawing.Size(309, 265);
            this.listBoxFiccao.TabIndex = 0;
            // 
            // lblRomance
            // 
            this.lblRomance.AutoSize = true;
            this.lblRomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRomance.Location = new System.Drawing.Point(765, 72);
            this.lblRomance.Name = "lblRomance";
            this.lblRomance.Size = new System.Drawing.Size(148, 29);
            this.lblRomance.TabIndex = 1;
            this.lblRomance.Text = "ROMANCE";
            // 
            // lblNaoFiccao
            // 
            this.lblNaoFiccao.AutoSize = true;
            this.lblNaoFiccao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoFiccao.Location = new System.Drawing.Point(416, 72);
            this.lblNaoFiccao.Name = "lblNaoFiccao";
            this.lblNaoFiccao.Size = new System.Drawing.Size(177, 29);
            this.lblNaoFiccao.TabIndex = 1;
            this.lblNaoFiccao.Text = "NÃO FICÇÃO";
            // 
            // lblFiccao
            // 
            this.lblFiccao.AutoSize = true;
            this.lblFiccao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiccao.Location = new System.Drawing.Point(108, 72);
            this.lblFiccao.Name = "lblFiccao";
            this.lblFiccao.Size = new System.Drawing.Size(112, 29);
            this.lblFiccao.TabIndex = 1;
            this.lblFiccao.Text = "FICÇÃO";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.lblGeneroPesq);
            this.gbPesquisa.Controls.Add(this.cbGeneroPesq);
            this.gbPesquisa.Controls.Add(this.lblPagPesq);
            this.gbPesquisa.Controls.Add(this.txtPagPesq);
            this.gbPesquisa.Controls.Add(this.lblPos);
            this.gbPesquisa.Controls.Add(this.cbPosicao);
            this.gbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisa.Location = new System.Drawing.Point(636, 12);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(411, 334);
            this.gbPesquisa.TabIndex = 7;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(131, 285);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(178, 43);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblGeneroPesq
            // 
            this.lblGeneroPesq.AutoSize = true;
            this.lblGeneroPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroPesq.Location = new System.Drawing.Point(16, 41);
            this.lblGeneroPesq.Name = "lblGeneroPesq";
            this.lblGeneroPesq.Size = new System.Drawing.Size(238, 29);
            this.lblGeneroPesq.TabIndex = 1;
            this.lblGeneroPesq.Text = "Selecione o gênero:";
            // 
            // cbGeneroPesq
            // 
            this.cbGeneroPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGeneroPesq.FormattingEnabled = true;
            this.cbGeneroPesq.Items.AddRange(new object[] {
            "FICÇÃO",
            "NAO-FIXCÇÃO",
            "ROMANCE"});
            this.cbGeneroPesq.Location = new System.Drawing.Point(21, 73);
            this.cbGeneroPesq.Name = "cbGeneroPesq";
            this.cbGeneroPesq.Size = new System.Drawing.Size(245, 37);
            this.cbGeneroPesq.TabIndex = 2;
            // 
            // lblPagPesq
            // 
            this.lblPagPesq.AutoSize = true;
            this.lblPagPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagPesq.Location = new System.Drawing.Point(16, 116);
            this.lblPagPesq.Name = "lblPagPesq";
            this.lblPagPesq.Size = new System.Drawing.Size(306, 29);
            this.lblPagPesq.TabIndex = 1;
            this.lblPagPesq.Text = "Informe a qntd de paginas";
            // 
            // txtPagPesq
            // 
            this.txtPagPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagPesq.Location = new System.Drawing.Point(21, 150);
            this.txtPagPesq.Name = "txtPagPesq";
            this.txtPagPesq.Size = new System.Drawing.Size(245, 36);
            this.txtPagPesq.TabIndex = 3;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(25, 199);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(241, 29);
            this.lblPos.TabIndex = 1;
            this.lblPos.Text = "Selecione a posição";
            // 
            // cbPosicao
            // 
            this.cbPosicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosicao.FormattingEnabled = true;
            this.cbPosicao.Items.AddRange(new object[] {
            "ACIMA",
            "IGUAL",
            "ABAIXO"});
            this.cbPosicao.Location = new System.Drawing.Point(21, 237);
            this.cbPosicao.Name = "cbPosicao";
            this.cbPosicao.Size = new System.Drawing.Size(245, 37);
            this.cbPosicao.TabIndex = 2;
            // 
            // frmLinq2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 746);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.gbLivros);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.label1);
            this.Name = "frmLinq2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLinq2";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbLivros.ResumeLayout(false);
            this.gbLivros.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.ComboBox cbGeneroAdd;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbLivros;
        private System.Windows.Forms.ListBox listBoxRomance;
        private System.Windows.Forms.ListBox listBoxNaoFiccao;
        private System.Windows.Forms.ListBox listBoxFiccao;
        private System.Windows.Forms.Label lblRomance;
        private System.Windows.Forms.Label lblNaoFiccao;
        private System.Windows.Forms.Label lblFiccao;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.Label lblGeneroPesq;
        private System.Windows.Forms.ComboBox cbGeneroPesq;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPagPesq;
        private System.Windows.Forms.TextBox txtPagPesq;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.ComboBox cbPosicao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}