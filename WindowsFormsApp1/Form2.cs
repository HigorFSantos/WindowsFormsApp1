using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String cep = txtCep.Text;
            try
            {
                if (cep.Length == 8)
                {
                    WebClient client = new WebClient();
                    var content = client.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");
                    MessageBox.Show(content);
                }
                else
                {
                    MessageBox.Show("CEP inválido",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("CEP inválido",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            {
                DateTime now = DateTime.Now;
                MessageBox.Show(now.ToString("HH:mm"));
            }
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            {
                DateTime now = DateTime.Now;
                MessageBox.Show(now.ToString("dd/MM/yyyy"));
            }
        }

        private void btnUsdb_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
                MessageBox.Show(content);
            }
        }

        private void btnUsd_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
                MessageBox.Show(content);
            }
        }
    }
}
