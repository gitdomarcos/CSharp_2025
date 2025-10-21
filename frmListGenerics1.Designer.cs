namespace CSharp_2025
{
    partial class frmListGenerics1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePrato = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxNomePrato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(149, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(276, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite o nome do prato:";
            // 
            // txtNomePrato
            // 
            this.txtNomePrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePrato.Location = new System.Drawing.Point(431, 81);
            this.txtNomePrato.Name = "txtNomePrato";
            this.txtNomePrato.Size = new System.Drawing.Size(253, 36);
            this.txtNomePrato.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(331, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxNomePrato
            // 
            this.listBoxNomePrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomePrato.FormattingEnabled = true;
            this.listBoxNomePrato.ItemHeight = 29;
            this.listBoxNomePrato.Location = new System.Drawing.Point(281, 234);
            this.listBoxNomePrato.Name = "listBoxNomePrato";
            this.listBoxNomePrato.Size = new System.Drawing.Size(413, 323);
            this.listBoxNomePrato.TabIndex = 3;
            // 
            // frmListGenerics1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 605);
            this.Controls.Add(this.listBoxNomePrato);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNomePrato);
            this.Controls.Add(this.lblNome);
            this.Name = "frmListGenerics1";
            this.Text = "frmListGenerics1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomePrato;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxNomePrato;
    }
}