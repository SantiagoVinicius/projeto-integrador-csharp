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
    public partial class listagemFuncionarios : Form
    {
        public listagemFuncionarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFuncionarios formulario = new frmFuncionarios();
            formulario.ShowDialog();
        }

        private void gridFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listagemFuncionarios_Load(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string sqlSelecionar = "SELECT * FROM tb_funcionarios";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar , conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridFuncionarios.DataSource = dt;
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void btnNomeBuscar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                string btnNomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_funcionarios WHERE nome like '%{btnNomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridFuncionarios.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                string btnNomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_funcionarios WHERE nome like '%{btnNomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridFuncionarios.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
;        }
    }
}
