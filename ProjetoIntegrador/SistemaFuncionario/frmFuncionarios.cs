using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaFuncionario
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDiasTrabalho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            SalvarPaciente(txtNome.Text , txtTelefone.Text , txtDiasTrabalho.Text, txtPeriodos.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtPeriodos.Clear();
            txtTelefone.Clear();
            txtDiasTrabalho.Clear();
          
        }

        private void SalvarPaciente(string nome , string telefone , string diasDeTrabalho , string periodoDeTrabalho)
        {
           
            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"insert into tb_funcionarios(nome , telefone , trabalha_dias , trabalha_horarios ) values('{nome}' , '{telefone}' , '{diasDeTrabalho}' , '{periodoDeTrabalho}')";
                cmd.ExecuteNonQuery();

                conexao.Close();
                MessageBox.Show("Cadastrado Com Sucesso!!!");
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados: " + erro.Message);
            }
        }
    }
}
