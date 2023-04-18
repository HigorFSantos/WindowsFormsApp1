using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login;
            String senha;

            login = txtLogin.Text;

            try
            {
                MailAddress loginValid = new MailAddress
                    (login);
                MessageBox.Show("E-mail válido");
            }
            catch
            {
                MessageBox.Show("E-mail inválido");
            }
            senha = txtSenha.Text;
            if (senha.Length >= 8)
            {
                MessageBox.Show("Senha Válida");
            }
            else
            {
                MessageBox.Show("Senha Inválida");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
