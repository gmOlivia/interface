using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class usuario : Form
    {
        MySqlConnection conexao;


        public usuario()
        {
            InitializeComponent();
        }

        public DataTable obterdados()
        {
            DataTable dt = new DataTable();
            string data_source = "datasource=localhost;username=root;password='';database=sistema";
            conexao = new MySqlConnection(data_source);
            string sql = "SELECT * from usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            conexao.Close();
            return dt;
        }


        private void usuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obterdados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //caminho de configuração do servidor
                string data_source = "datasource=localhost;username=root;password= '';database=sistema";

                //abrindo a conexão
                conexao = new MySqlConnection(data_source);

                //criando script sql para inserir as informações
                string sql = "insert into usuario(nome, email, senha) values ('" + NOme.Text + "','" + Email.Text + "','" + Senha.Text + "')";

                //montar o script sql para executar
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //abrir o banco de dados
                conexao.Open();


                //se tiver vazio
                if (NOme.Text == "")
                {
                    MessageBox.Show("Nome está vazio!");
                }
                else
                {
                    MessageBox.Show("Campo preenchido!");
                }
                if (Email.Text == "")
                {
                    MessageBox.Show("Email está vazio!");
                }
                if (Senha.Text == "")
                {
                    MessageBox.Show("Senha está vazio!");
                }
                if (Senha.Text != "" && Email.Text != "" && NOme.Text != "")
                {
                    //executar a consulta no banco de dados
                    comando.ExecuteNonQuery();
                    dataGridView1.DataSource = obterdados();
                    limparCampos();
                }
                conexao.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void limparCampos()
        {
            NOme.Clear();
            Email.Clear();
            Senha.Clear();
            txtid.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            //converter a linha selecionada a coluna texto para inteiro
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //atribuir o codigo do usuario para o campo id
            txtid.Text = codigo.ToString(); // convertendo texto
            //recebe no capo nome o valor do nome do usuario
            NOme.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            Email.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            Senha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password='';database=sistema";
            conexao = new MySqlConnection(data_source);
            string sql = "DELETE FROM USUARIO WHERE id=" + Convert.ToInt32(txtid.Text);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Usuário excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Error na exclusão do usuário");
            }

        }
    } 
} 
