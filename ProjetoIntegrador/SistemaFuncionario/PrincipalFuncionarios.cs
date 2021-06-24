using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFuncionario
{
    public partial class PrincipalFuncionarios : Form
    {
        public PrincipalFuncionarios()
        {
            InitializeComponent();
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listagemFuncionarios formulario = new listagemFuncionarios();
            formulario.ShowDialog();
        }

        private void novoFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarios formulario = new frmFuncionarios();
            formulario.ShowDialog();
        }
    }
}
