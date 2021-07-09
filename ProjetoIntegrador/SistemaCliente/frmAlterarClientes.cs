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
    public partial class frmAlterarClientes : Form
    {
        public frmAlterarClientes()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string idCliente = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;passoword=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                string sexo = "";
                
                string faxa = "";
              




                conexao.Open();
                string sqlBuscar = $"SELECT * FROM tb_clientes WHERE id={idCliente}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                sexo = dt.Rows[0]["sexo"].ToString();
                
                if(sexo == "Feminino")
                {
                    rbnFeminino.Checked = true;
                }
                else
                {
                    rbnMasculino.Checked = true;
                }

                faxa = dt.Rows[0]["adulto"].ToString();
                
                if(faxa == "Adulto")
                {
                    cbAdulto.Checked = true;
                }
                else
                {
                    cbAdulto.Checked = false;
                }
          
                txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                txtDescricao.Text = dt.Rows[0]["descricao"].ToString();
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
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
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_clientes set nome='{txtNome.Text}' , telefone='{txtTelefone.Text}' , sexo='{sexo}' , adulto='{faxa}' , descricao='{txtDescricao.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a Conexão . Erro:" + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            string idCliente = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_clientes WHERE id={idCliente}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente excluído com Sucesso!");
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

