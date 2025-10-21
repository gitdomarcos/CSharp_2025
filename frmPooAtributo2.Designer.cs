namespace CSharp_2025
{
    partial class frmPooAtributo2
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
            this.gbfrmPooAtributo2 = new System.Windows.Forms.GroupBox();
            this.txtNomeEscola = new System.Windows.Forms.TextBox();
            this.lblNomeEscola = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNomeDiretor = new System.Windows.Forms.Label();
            this.lblQntdProfessores = new System.Windows.Forms.Label();
            this.lblQntdAlunos = new System.Windows.Forms.Label();
            this.txtNomeDiretor = new System.Windows.Forms.TextBox();
            this.txtQntdProf = new System.Windows.Forms.TextBox();
            this.txtQntdAlunos = new System.Windows.Forms.TextBox();
            this.grdListaCadastro = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbfrmPooAtributo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfrmPooAtributo2
            // 
            this.gbfrmPooAtributo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbfrmPooAtributo2.Controls.Add(this.btnCancelar);
            this.gbfrmPooAtributo2.Controls.Add(this.btnCadastrar);
            this.gbfrmPooAtributo2.Controls.Add(this.grdListaCadastro);
            this.gbfrmPooAtributo2.Controls.Add(this.txtQntdAlunos);
            this.gbfrmPooAtributo2.Controls.Add(this.txtQntdProf);
            this.gbfrmPooAtributo2.Controls.Add(this.txtNomeDiretor);
            this.gbfrmPooAtributo2.Controls.Add(this.lblQntdAlunos);
            this.gbfrmPooAtributo2.Controls.Add(this.txtNomeEscola);
            this.gbfrmPooAtributo2.Controls.Add(this.lblQntdProfessores);
            this.gbfrmPooAtributo2.Controls.Add(this.lblNomeDiretor);
            this.gbfrmPooAtributo2.Controls.Add(this.lblNomeEscola);
            this.gbfrmPooAtributo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfrmPooAtributo2.Location = new System.Drawing.Point(12, 12);
            this.gbfrmPooAtributo2.Name = "gbfrmPooAtributo2";
            this.gbfrmPooAtributo2.Size = new System.Drawing.Size(902, 562);
            this.gbfrmPooAtributo2.TabIndex = 0;
            this.gbfrmPooAtributo2.TabStop = false;
            this.gbfrmPooAtributo2.Text = "Exercício 02 – POO: Métodos";
            // 
            // txtNomeEscola
            // 
            this.txtNomeEscola.Location = new System.Drawing.Point(320, 47);
            this.txtNomeEscola.Name = "txtNomeEscola";
            this.txtNomeEscola.Size = new System.Drawing.Size(272, 36);
            this.txtNomeEscola.TabIndex = 1;
            // 
            // lblNomeEscola
            // 
            this.lblNomeEscola.AutoSize = true;
            this.lblNomeEscola.Location = new System.Drawing.Point(98, 50);
            this.lblNomeEscola.Name = "lblNomeEscola";
            this.lblNomeEscola.Size = new System.Drawing.Size(207, 29);
            this.lblNomeEscola.TabIndex = 2;
            this.lblNomeEscola.Text = "Nome da Escola:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(545, 513);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 39);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNomeDiretor
            // 
            this.lblNomeDiretor.AutoSize = true;
            this.lblNomeDiretor.Location = new System.Drawing.Point(104, 102);
            this.lblNomeDiretor.Name = "lblNomeDiretor";
            this.lblNomeDiretor.Size = new System.Drawing.Size(201, 29);
            this.lblNomeDiretor.TabIndex = 3;
            this.lblNomeDiretor.Text = "Nome do diretor:";
            // 
            // lblQntdProfessores
            // 
            this.lblQntdProfessores.AutoSize = true;
            this.lblQntdProfessores.Location = new System.Drawing.Point(16, 154);
            this.lblQntdProfessores.Name = "lblQntdProfessores";
            this.lblQntdProfessores.Size = new System.Drawing.Size(289, 29);
            this.lblQntdProfessores.TabIndex = 4;
            this.lblQntdProfessores.Text = "Quantidade professores:";
            // 
            // lblQntdAlunos
            // 
            this.lblQntdAlunos.AutoSize = true;
            this.lblQntdAlunos.Location = new System.Drawing.Point(73, 206);
            this.lblQntdAlunos.Name = "lblQntdAlunos";
            this.lblQntdAlunos.Size = new System.Drawing.Size(232, 29);
            this.lblQntdAlunos.TabIndex = 5;
            this.lblQntdAlunos.Text = "Quantidade alunos:";
            // 
            // txtNomeDiretor
            // 
            this.txtNomeDiretor.Location = new System.Drawing.Point(320, 99);
            this.txtNomeDiretor.Name = "txtNomeDiretor";
            this.txtNomeDiretor.Size = new System.Drawing.Size(272, 36);
            this.txtNomeDiretor.TabIndex = 2;
            // 
            // txtQntdProf
            // 
            this.txtQntdProf.Location = new System.Drawing.Point(320, 151);
            this.txtQntdProf.Name = "txtQntdProf";
            this.txtQntdProf.Size = new System.Drawing.Size(272, 36);
            this.txtQntdProf.TabIndex = 3;
            // 
            // txtQntdAlunos
            // 
            this.txtQntdAlunos.Location = new System.Drawing.Point(320, 203);
            this.txtQntdAlunos.Name = "txtQntdAlunos";
            this.txtQntdAlunos.Size = new System.Drawing.Size(272, 36);
            this.txtQntdAlunos.TabIndex = 4;
            // 
            // grdListaCadastro
            // 
            this.grdListaCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdListaCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCadastro.Location = new System.Drawing.Point(10, 266);
            this.grdListaCadastro.Name = "grdListaCadastro";
            this.grdListaCadastro.ReadOnly = true;
            this.grdListaCadastro.RowHeadersWidth = 51;
            this.grdListaCadastro.RowTemplate.Height = 24;
            this.grdListaCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaCadastro.Size = new System.Drawing.Size(876, 241);
            this.grdListaCadastro.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(721, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPooAtributo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(924, 584);
            this.Controls.Add(this.gbfrmPooAtributo2);
            this.Name = "frmPooAtributo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPooAtributo2";
            this.gbfrmPooAtributo2.ResumeLayout(false);
            this.gbfrmPooAtributo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfrmPooAtributo2;
        private System.Windows.Forms.TextBox txtNomeEscola;
        private System.Windows.Forms.Label lblNomeEscola;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtQntdAlunos;
        private System.Windows.Forms.TextBox txtQntdProf;
        private System.Windows.Forms.TextBox txtNomeDiretor;
        private System.Windows.Forms.Label lblQntdAlunos;
        private System.Windows.Forms.Label lblQntdProfessores;
        private System.Windows.Forms.Label lblNomeDiretor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdListaCadastro;
    }
}