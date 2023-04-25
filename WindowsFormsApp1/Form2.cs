using Newtonsoft.Json;
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
        DateTime now = DateTime.Now;

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
                    Endereco end = JsonConvert.DeserializeObject<Endereco>(content);
                    MessageBox.Show(end.logradouro + end.cep + end.bairro);

                    lstCep.Items.Add(end.logradouro + "/n" + end.cep + end.bairro + now.ToString("dd/MM/yyyy | HH:mm"));
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
                MessageBox.Show(now.ToString("HH:mm"));
                lstHoras.Items.Add(now.ToString("dd/MM/yyyy | HH:mm"));
            }
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(now.ToString("dd/MM/yyyy"));
                lstData.Items.Add(now.ToString("dd/MM/yyyy | HH:mm"));
            }
        }

        private void btnUsdb_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
                MessageBox.Show(content);
                lstUsd.Items.Add(content + now.ToString("dd/MM/yyyy | HH:mm"));
                
            }
        }

        private void btnUsd_Click(object sender, EventArgs e)
        {
            {
                WebClient client = new WebClient();
                var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
                MessageBox.Show(content);
                lstBrl.Items.Add(content + now.ToString("dd/MM/yyyy | HH:mm"));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}