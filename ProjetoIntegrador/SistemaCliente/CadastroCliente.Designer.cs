namespace SistemaCliente
{
    partial class frmCadastroCliente
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.cbAdulto = new System.Windows.Forms.CheckBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(50, 264);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(194, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "DIGITE SEU NOME COMPLETO";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnMasculino);
            this.groupBox1.Controls.Add(this.rbnFeminino);
            this.groupBox1.Location = new System.Drawing.Point(145, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(6, 36);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 7;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Checked = true;
            this.rbnFeminino.Location = new System.Drawing.Point(6, 13);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbnFeminino.TabIndex = 6;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            // 
            // cbAdulto
            // 
            this.cbAdulto.AutoSize = true;
            this.cbAdulto.Location = new System.Drawing.Point(50, 114);
            this.cbAdulto.Name = "cbAdulto";
            this.cbAdulto.Size = new System.Drawing.Size(70, 17);
            this.cbAdulto.TabIndex = 9;
            this.cbAdulto.Text = "ADULTO";
            this.cbAdulto.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(119, 73);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(140, 20);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.Text = "DIGITE SEU NÚMERO";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(50, 192);
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(194, 49);
            this.txtDescrição.TabIndex = 11;
            this.txtDescrição.Text = "DIGITE INFORMAÇÕES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TELEFONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DESCRIÇÃO:";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cbAdulto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastroCliente";
            this.Text = "CadastroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.CheckBox cbAdulto;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}