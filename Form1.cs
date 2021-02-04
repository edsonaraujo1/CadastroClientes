using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

/*
 ------------------------------------------------
 Desenvolvido por...: Edson de Araujo
 Finalidade.........: Sistema Cadastro Menu Principal
 Criado em Data.....: 26/01/2021
 Ultima Atualização : 26/01/2021 

 DEUS SEJA LOUVADO
 ------------------------------------------------
*/

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            About AboutMDIChild = new About();

            AboutMDIChild.MdiParent = this;

            AboutMDIChild.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - AboutMDIChild.Width) / 2;

            int y = (this.Height - AboutMDIChild.Height) / 2;

            AboutMDIChild.Location = new Point(x, y);

            AboutMDIChild.Show();


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "WindForm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //txtNome.Focus();
            }

        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2MDIChild = new Form2();

            Form2MDIChild.MdiParent = this;

            Form2MDIChild.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - Form2MDIChild.Width) / 2;

            int y = (this.Height - Form2MDIChild.Height) / 2;

            Form2MDIChild.Location = new Point(x, y);

            Form2MDIChild.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }

        private void scannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3MDIChild = new Form3();

            Form3MDIChild.MdiParent = this;

            Form3MDIChild.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - Form3MDIChild.Width) / 2;

            int y = (this.Height - Form3MDIChild.Height) / 2;

            Form3MDIChild.Location = new Point(x, y);

            Form3MDIChild.Show();

        }
    }
}
