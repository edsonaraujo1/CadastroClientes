using System;
using System.Data;
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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = WinForm1; User Id = sa; Password = 12345;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Form2()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM Contatos", con);
                adapt.Fill(dt);
                dgvAgenda.DataSource = dt;
            }
            catch
            {
                //throw;
                MessageBox.Show("Dados Não Encontrados!");
            }
            finally
            {
                con.Close();
            }
        }

        private void LimparDados()
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEndereco.Text != "" && txtCelular.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Contatos(nome,endereco,celular,telefone,email) VALUES(@nome,@endereco,@celular,@telefone,@email)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }

        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEndereco.Text != "" && txtCelular.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Contatos SET nome=@nome, endereco=@endereco, celular=@celular,telefone=@telefone,email=@email WHERE id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }

        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Contatos WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        ExibirDados();
                        LimparDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2 Form2Exit = new Form2();
            Form2Exit.Hide();
            Form2Exit.Close();

        }

        private void dgvAgenda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEndereco.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCelular.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefone.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dgvAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bOTÃO nOVO!!!!!");
        }
    }
}
