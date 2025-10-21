namespace CSharp_2025
{
    partial class frmLinq3
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
            this.lblEx3 = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.lblGrupoEtario = new System.Windows.Forms.Label();
            this.cbGrupoEtarioCadastro = new System.Windows.Forms.ComboBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblFiltroGrupo = new System.Windows.Forms.Label();
            this.cbGrupoEtarioPesquisa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblValorRef = new System.Windows.Forms.Label();
            this.txtValorPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.listBoxInfantil = new System.Windows.Forms.ListBox();
            this.listBoxJuvenil = new System.Windows.Forms.ListBox();
            this.listBoxAdulto = new System.Windows.Forms.ListBox();
            this.lblInfantil = new System.Windows.Forms.Label();
            this.lblJuvenil = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.gbCadastro.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEx3
            // 
            this.lblEx3.AutoSize = true;
            this.lblEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx3.Location = new System.Drawing.Point(12, 9);
            this.lblEx3.Name = "lblEx3";
            this.lblEx3.Size = new System.Drawing.Size(240, 29);
            this.lblEx3.TabIndex = 4;
            this.lblEx3.Text = "Exercicio 03 - Linq";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.btnLimpar);
            this.gbCadastro.Controls.Add(this.btnAdd);
            this.gbCadastro.Controls.Add(this.txtAltura);
            this.gbCadastro.Controls.Add(this.lblAltura);
            this.gbCadastro.Controls.Add(this.cbGrupoEtarioCadastro);
            this.gbCadastro.Controls.Add(this.lblGrupoEtario);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(17, 52);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(508, 240);
            this.gbCadastro.TabIndex = 5;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            // 
            // lblGrupoEtario
            // 
            this.lblGrupoEtario.AutoSize = true;
            this.lblGrupoEtario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoEtario.Location = new System.Drawing.Point(6, 43);
            this.lblGrupoEtario.Name = "lblGrupoEtario";
            this.lblGrupoEtario.Size = new System.Drawing.Size(267, 29);
            this.lblGrupoEtario.TabIndex = 6;
            this.lblGrupoEtario.Text = "Informe o grupo etário:";
            // 
            // cbGrupoEtarioCadastro
            // 
            this.cbGrupoEtarioCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoEtarioCadastro.FormattingEnabled = true;
            this.cbGrupoEtarioCadastro.Items.AddRange(new object[] {
            "INFANTIL",
            "JUVENIL",
            "ADULTO"});
            this.cbGrupoEtarioCadastro.Location = new System.Drawing.Point(279, 40);
            this.cbGrupoEtarioCadastro.Name = "cbGrupoEtarioCadastro";
            this.cbGrupoEtarioCadastro.Size = new System.Drawing.Size(206, 37);
            this.cbGrupoEtarioCadastro.TabIndex = 6;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(77, 86);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(196, 29);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Informe a altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(279, 83);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(206, 36);
            this.txtAltura.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 44);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(340, 178);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 44);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.txtValorPesquisa);
            this.gbPesquisa.Controls.Add(this.lblValorRef);
            this.gbPesquisa.Controls.Add(this.comboBox2);
            this.gbPesquisa.Controls.Add(this.label2);
            this.gbPesquisa.Controls.Add(this.cbGrupoEtarioPesquisa);
            this.gbPesquisa.Controls.Add(this.lblFiltroGrupo);
            this.gbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisa.Location = new System.Drawing.Point(556, 52);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(584, 240);
            this.gbPesquisa.TabIndex = 6;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // lblFiltroGrupo
            // 
            this.lblFiltroGrupo.AutoSize = true;
            this.lblFiltroGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroGrupo.Location = new System.Drawing.Point(142, 43);
            this.lblFiltroGrupo.Name = "lblFiltroGrupo";
            this.lblFiltroGrupo.Size = new System.Drawing.Size(198, 29);
            this.lblFiltroGrupo.TabIndex = 7;
            this.lblFiltroGrupo.Text = "Filtrar por grupo:";
            // 
            // cbGrupoEtarioPesquisa
            // 
            this.cbGrupoEtarioPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoEtarioPesquisa.FormattingEnabled = true;
            this.cbGrupoEtarioPesquisa.Items.AddRange(new object[] {
            "INFANTIL",
            "JUVENIL",
            "ADULTO"});
            this.cbGrupoEtarioPesquisa.Location = new System.Drawing.Point(336, 39);
            this.cbGrupoEtarioPesquisa.Name = "cbGrupoEtarioPesquisa";
            this.cbGrupoEtarioPesquisa.Size = new System.Drawing.Size(232, 37);
            this.cbGrupoEtarioPesquisa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione uma opção:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ACIMA",
            "IGUAL",
            "ABAIXO"});
            this.comboBox2.Location = new System.Drawing.Point(336, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 37);
            this.comboBox2.TabIndex = 7;
            // 
            // lblValorRef
            // 
            this.lblValorRef.AutoSize = true;
            this.lblValorRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRef.Location = new System.Drawing.Point(19, 129);
            this.lblValorRef.Name = "lblValorRef";
            this.lblValorRef.Size = new System.Drawing.Size(321, 29);
            this.lblValorRef.TabIndex = 11;
            this.lblValorRef.Text = "Informe valor de referência:";
            // 
            // txtValorPesquisa
            // 
            this.txtValorPesquisa.Location = new System.Drawing.Point(337, 126);
            this.txtValorPesquisa.Name = "txtValorPesquisa";
            this.txtValorPesquisa.Size = new System.Drawing.Size(231, 36);
            this.txtValorPesquisa.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(423, 178);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 44);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lblAdulto);
            this.gbResultado.Controls.Add(this.lblJuvenil);
            this.gbResultado.Controls.Add(this.lblInfantil);
            this.gbResultado.Controls.Add(this.listBoxAdulto);
            this.gbResultado.Controls.Add(this.listBoxJuvenil);
            this.gbResultado.Controls.Add(this.listBoxInfantil);
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(17, 298);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(1123, 389);
            this.gbResultado.TabIndex = 7;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Grupo Etário";
            // 
            // listBoxInfantil
            // 
            this.listBoxInfantil.FormattingEnabled = true;
            this.listBoxInfantil.ItemHeight = 29;
            this.listBoxInfantil.Location = new System.Drawing.Point(94, 92);
            this.listBoxInfantil.Name = "listBoxInfantil";
            this.listBoxInfantil.Size = new System.Drawing.Size(261, 265);
            this.listBoxInfantil.TabIndex = 0;
            // 
            // listBoxJuvenil
            // 
            this.listBoxJuvenil.FormattingEnabled = true;
            this.listBoxJuvenil.ItemHeight = 29;
            this.listBoxJuvenil.Location = new System.Drawing.Point(449, 92);
            this.listBoxJuvenil.Name = "listBoxJuvenil";
            this.listBoxJuvenil.Size = new System.Drawing.Size(261, 265);
            this.listBoxJuvenil.TabIndex = 1;
            // 
            // listBoxAdulto
            // 
            this.listBoxAdulto.FormattingEnabled = true;
            this.listBoxAdulto.ItemHeight = 29;
            this.listBoxAdulto.Location = new System.Drawing.Point(782, 92);
            this.listBoxAdulto.Name = "listBoxAdulto";
            this.listBoxAdulto.Size = new System.Drawing.Size(261, 265);
            this.listBoxAdulto.TabIndex = 2;
            // 
            // lblInfantil
            // 
            this.lblInfantil.AutoSize = true;
            this.lblInfantil.Location = new System.Drawing.Point(181, 48);
            this.lblInfantil.Name = "lblInfantil";
            this.lblInfantil.Size = new System.Drawing.Size(87, 29);
            this.lblInfantil.TabIndex = 3;
            this.lblInfantil.Text = "Infantil";
            // 
            // lblJuvenil
            // 
            this.lblJuvenil.AutoSize = true;
            this.lblJuvenil.Location = new System.Drawing.Point(529, 48);
            this.lblJuvenil.Name = "lblJuvenil";
            this.lblJuvenil.Size = new System.Drawing.Size(93, 29);
            this.lblJuvenil.TabIndex = 4;
            this.lblJuvenil.Text = "Juvenil";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(874, 48);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(85, 29);
            this.lblAdulto.TabIndex = 5;
            this.lblAdulto.Text = "Adulto";
            // 
            // frmLinq3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 699);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.lblEx3);
            this.Name = "frmLinq3";
            this.Text = "frmLinq3";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEx3;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.ComboBox cbGrupoEtarioCadastro;
        private System.Windows.Forms.Label lblGrupoEtario;
        private System.Windows.Forms.ComboBox cbGrupoEtarioPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.Label lblFiltroGrupo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtValorPesquisa;
        private System.Windows.Forms.Label lblValorRef;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.Label lblJuvenil;
        private System.Windows.Forms.Label lblInfantil;
        private System.Windows.Forms.ListBox listBoxAdulto;
        private System.Windows.Forms.ListBox listBoxJuvenil;
        private System.Windows.Forms.ListBox listBoxInfantil;
    }
}