namespace CSharp_2025
{
    partial class frmPraticaListObj
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
            this.gbListObj = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.grdAlunos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.gbListObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListObj
            // 
            this.gbListObj.Controls.Add(this.cbFiltro);
            this.gbListObj.Controls.Add(this.btnRelatorio);
            this.gbListObj.Controls.Add(this.grdAlunos);
            this.gbListObj.Controls.Add(this.btnExcluir);
            this.gbListObj.Controls.Add(this.btnAlterar);
            this.gbListObj.Controls.Add(this.btnCancelar);
            this.gbListObj.Controls.Add(this.btnCadastrar);
            this.gbListObj.Controls.Add(this.txtNota4);
            this.gbListObj.Controls.Add(this.txtNota3);
            this.gbListObj.Controls.Add(this.txtNota2);
            this.gbListObj.Controls.Add(this.txtNota1);
            this.gbListObj.Controls.Add(this.txtNome);
            this.gbListObj.Controls.Add(this.lblNota4);
            this.gbListObj.Controls.Add(this.lblNota3);
            this.gbListObj.Controls.Add(this.lblNota2);
            this.gbListObj.Controls.Add(this.lblNota1);
            this.gbListObj.Controls.Add(this.lblNomeAluno);
            this.gbListObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListObj.Location = new System.Drawing.Point(12, 12);
            this.gbListObj.Name = "gbListObj";
            this.gbListObj.Size = new System.Drawing.Size(1162, 700);
            this.gbListObj.TabIndex = 0;
            this.gbListObj.TabStop = false;
            this.gbListObj.Text = "Prática de Lista Objeto - Classe com métodos e atributos";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "SEM FILTRO",
            "REPROVADO",
            "EXAME",
            "APROVADO"});
            this.cbFiltro.Location = new System.Drawing.Point(311, 311);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(378, 37);
            this.cbFiltro.TabIndex = 12;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRelatorio.Location = new System.Drawing.Point(926, 644);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(230, 50);
            this.btnRelatorio.TabIndex = 11;
            this.btnRelatorio.Text = "Gerar Arquivo";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // grdAlunos
            // 
            this.grdAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlunos.Location = new System.Drawing.Point(6, 371);
            this.grdAlunos.Name = "grdAlunos";
            this.grdAlunos.ReadOnly = true;
            this.grdAlunos.RowHeadersWidth = 51;
            this.grdAlunos.RowTemplate.Height = 24;
            this.grdAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAlunos.Size = new System.Drawing.Size(1150, 267);
            this.grdAlunos.TabIndex = 10;
            this.grdAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlunos_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Location = new System.Drawing.Point(726, 229);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(172, 50);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.Location = new System.Drawing.Point(517, 229);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(172, 50);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(306, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 50);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(103, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 50);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(843, 146);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(115, 36);
            this.txtNota4.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(595, 146);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(115, 36);
            this.txtNota3.TabIndex = 4;
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(349, 146);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(115, 36);
            this.txtNota2.TabIndex = 3;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(110, 146);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(115, 36);
            this.txtNota1.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(233, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(725, 36);
            this.txtNome.TabIndex = 1;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(743, 149);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(94, 29);
            this.lblNota4.TabIndex = 0;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(495, 149);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(94, 29);
            this.lblNota3.TabIndex = 0;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(249, 149);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(94, 29);
            this.lblNota2.TabIndex = 0;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(10, 149);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(94, 29);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(29, 69);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(195, 29);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // frmPraticaListObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 724);
            this.Controls.Add(this.gbListObj);
            this.Name = "frmPraticaListObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPraticaListObj";
            this.Load += new System.EventHandler(this.frmPraticaListObj_Load);
            this.gbListObj.ResumeLayout(false);
            this.gbListObj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListObj;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.DataGridView grdAlunos;
        private System.Windows.Forms.ComboBox cbFiltro;
    }
}