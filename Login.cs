using System;
using System.Data.SqlClient;
using System.Windows.Forms;

/*
 ------------------------------------------------
 Desenvolvido por...: Edson de Araujo
 Finalidade.........: Sistema Cadastro
 Criado em Data.....: 26/01/2021
 Ultima Atualização : 26/01/2021 

 DEUS SEJA LOUVADO
 ------------------------------------------------
*/

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private bool Logado = false;

        public Login()
        {
            InitializeComponent();

            txtSenha.Text = null;
            txtUsuario.Text = null;
            txtUsuario.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool result = VerificaLogin();

            Logado = result;

            if (result)
            {
                MessageBox.Show("Seja bem vindo!", "Login");
                this.Hide();
                Form1 Form1MDIChild = new Form1();
                Form1MDIChild.Show();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!", "Login");
                txtSenha.Text = null;
                txtUsuario.Text = null;
                txtUsuario.Focus();
            }

        }

        bool VerificaLogin()
        {
            bool result = false;
            string StringDeConexao = @"Data Source = localhost; Initial Catalog = WinForm1; User Id = sa; Password = 12345;";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                try
                {
                    SqlCommand cmd = new SqlCommand("select * from login where usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "';", cn);
                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;

                }
                catch (SqlException e)
                {
                    //throw new Exception(e.Message);
                    MessageBox.Show("Usuário ou senha incorreto! \n Erro: ", "Login" + e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Logado)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }

}
