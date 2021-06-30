using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaFuncionario
{
    public partial class frmAlterarFuncionarios : Form
    {
        public frmAlterarFuncionarios()
        {
            InitializeComponent();
        }

        private void frmAlterarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string idFuncionario = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string sqlBuscar = $"SELECT * FROM tb_funcionarios WHERE id={idFuncionario}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                 txtTel.Text = dt.Rows[0]["telefone"].ToString();
               txtDiasTrabalho.Text = dt.Rows[0]["trabalha_dias"].ToString();
                txtPeriodo.Text = dt.Rows[0]["trabalha_horarios"].ToString();
                conexao.Close();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_funcionarios set nome='{txtNome.Text}' , telefone='{txtTel.Text}' , trabalha_dias='{txtDiasTrabalho.Text}' , trabalha_horarios='{txtPeriodo.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            string idFuncionario = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_funcionarios WHERE id={idFuncionario}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Funcionário excluído com Sucesso!");
                txtNome.Clear();
                txtID.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }
    }
}
