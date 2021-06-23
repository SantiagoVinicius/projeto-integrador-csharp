namespace SistemaFuncionario
{
    partial class frmFuncionarios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.btnCadastroFuncionarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiasTrabalho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.BackColor = System.Drawing.Color.Gray;
            this.btnCadastroFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(261, 188);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(159, 65);
            this.btnCadastroFuncionarios.TabIndex = 0;
            this.btnCadastroFuncionarios.Text = "Cadastrar Funcionários";
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = false;
            this.btnCadastroFuncionarios.Click += new System.EventHandler(this.btnCadastroFuncionarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(102, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(129, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(257, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(98, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias de Trabalho:";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPeriodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeriodos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPeriodos.Location = new System.Drawing.Point(261, 148);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(159, 20);
            this.txtPeriodos.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefone.Location = new System.Drawing.Point(261, 87);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(159, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(257, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Períodos de Trabalho:";
            // 
            // txtDiasTrabalho
            // 
            this.txtDiasTrabalho.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtDiasTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiasTrabalho.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDiasTrabalho.Location = new System.Drawing.Point(102, 148);
            this.txtDiasTrabalho.Name = "txtDiasTrabalho";
            this.txtDiasTrabalho.Size = new System.Drawing.Size(129, 20);
            this.txtDiasTrabalho.TabIndex = 8;
            this.txtDiasTrabalho.TextChanged += new System.EventHandler(this.txtDiasTrabalho_TextChanged);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFuncionario.Properties.Resources.sobreposicao_de_fundo_de_formularios_com_formas_23_2148664173;
            this.ClientSize = new System.Drawing.Size(545, 265);
            this.Controls.Add(this.txtDiasTrabalho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtPeriodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastroFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiasTrabalho;
    }
}

