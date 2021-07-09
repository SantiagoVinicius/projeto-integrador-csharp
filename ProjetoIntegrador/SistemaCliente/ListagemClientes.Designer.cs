namespace SistemaCliente
{
    partial class ListagemClientes
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
            this.btnNomeBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNomeBuscar
            // 
            this.btnNomeBuscar.Location = new System.Drawing.Point(665, 88);
            this.btnNomeBuscar.Name = "btnNomeBuscar";
            this.btnNomeBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnNomeBuscar.TabIndex = 11;
            this.btnNomeBuscar.Text = "Buscar";
            this.btnNomeBuscar.UseVisualStyleBackColor = true;
            this.btnNomeBuscar.Click += new System.EventHandler(this.btnNomeBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "INFORME PARTE DO NOME:\r\n";
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Location = new System.Drawing.Point(40, 91);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(619, 20);
            this.txtNomeBuscar.TabIndex = 9;
            this.txtNomeBuscar.TextChanged += new System.EventHandler(this.txtNomeBuscar_TextChanged);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(40, 117);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(748, 209);
            this.gridClientes.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Novo Funcionario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LISTAGEM DE FUNCIONARIOS";
            // 
            // ListagemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNomeBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ListagemClientes";
            this.Text = "ListagemClientes";
            this.Load += new System.EventHandler(this.ListagemClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNomeBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}