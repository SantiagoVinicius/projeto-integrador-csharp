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
using System.IO;

namespace SistemaCliente
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (rbnMasculino.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Feminino";
            }

            string faxa = "";
            if (cbAdulto.Checked)
            {
                faxa = "Adulto";
            }
            else
            {
                faxa = "Criança";
            }

            SalvarCliente(txtNome.Text, txtTelefone.Text, sexo, faxa, txtDescrição.Text);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtDescrição.Clear();

        }
        private void SalvarCliente(string nome, string telefone, string sexo, string faxa, string descricao)
        {
            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"insert into tb_clientes(nome , telefone , sexo , adulto , descricao ) values('{nome}' , '{telefone}' , '{sexo}' , '{faxa}' , '{descricao}')";
                cmd.ExecuteNonQuery();

                conexao.Close();
                MessageBox.Show("Cadastrado Com Sucesso!!!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados: " + erro.Message);
            }
        }
    }
}
