namespace CSharp_2025
{
    partial class frmXML_CRUD
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
            this.gbXML = new System.Windows.Forms.GroupBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.grdPessoa = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbXML
            // 
            this.gbXML.Controls.Add(this.btnXML);
            this.gbXML.Controls.Add(this.grdPessoa);
            this.gbXML.Controls.Add(this.btnExcluir);
            this.gbXML.Controls.Add(this.btnAlterar);
            this.gbXML.Controls.Add(this.btnCancelar);
            this.gbXML.Controls.Add(this.btnCadastrar);
            this.gbXML.Controls.Add(this.lblBairro);
            this.gbXML.Controls.Add(this.txtBairro);
            this.gbXML.Controls.Add(this.lblRua);
            this.gbXML.Controls.Add(this.txtRua);
            this.gbXML.Controls.Add(this.lblCodigo);
            this.gbXML.Controls.Add(this.txtCodigo);
            this.gbXML.Controls.Add(this.lblNome);
            this.gbXML.Controls.Add(this.txtNome);
            this.gbXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXML.Location = new System.Drawing.Point(12, 12);
            this.gbXML.Name = "gbXML";
            this.gbXML.Size = new System.Drawing.Size(1400, 726);
            this.gbXML.TabIndex = 0;
            this.gbXML.TabStop = false;
            this.gbXML.Text = "XML - CRUD";
            // 
            // btnXML
            // 
            this.btnXML.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXML.Location = new System.Drawing.Point(1218, 659);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(171, 55);
            this.btnXML.TabIndex = 9;
            this.btnXML.Text = "Gerar XML";
            this.btnXML.UseVisualStyleBackColor = true;
            // 
            // grdPessoa
            // 
            this.grdPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPessoa.Location = new System.Drawing.Point(6, 331);
            this.grdPessoa.Name = "grdPessoa";
            this.grdPessoa.RowHeadersWidth = 51;
            this.grdPessoa.RowTemplate.Height = 24;
            this.grdPessoa.Size = new System.Drawing.Size(1388, 318);
            this.grdPessoa.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Location = new System.Drawing.Point(1012, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(250, 67);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.Location = new System.Drawing.Point(732, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(250, 67);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.Location = new System.Drawing.Point(455, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 67);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(163, 248);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(250, 67);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(43, 187);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(94, 29);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(140, 183);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(285, 36);
            this.txtBairro.TabIndex = 3;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(64, 141);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(70, 29);
            this.lblRua.TabIndex = 1;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(140, 137);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(285, 36);
            this.txtRua.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 29);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(140, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 36);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(141, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(285, 36);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(30, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(107, 29);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // frmXML_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 750);
            this.Controls.Add(this.gbXML);
            this.Name = "frmXML_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXML_CRUD";
            this.Load += new System.EventHandler(this.frmXML_CRUD_Load);
            this.gbXML.ResumeLayout(false);
            this.gbXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbXML;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView grdPessoa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}