using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoWindowsForms
{
    public partial class Form1 : Form
    {
        Cotacoes cotacoes = new Cotacoes();
        string valorString;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cotacoes.VerCotacao("Dollar");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cotacoes.VerCotacao("Euro");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            valorString = Valortxt.Text;

        }

        public void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float valorBuy = float.Parse(cotacoes.buy, CultureInfo.InvariantCulture.NumberFormat);
                float ValorRecebido = float.Parse(valorString);
                valorBuy *= ValorRecebido;
                MessageBox.Show("Convertendo " + cotacoes.name + " para real fica R$" + valorBuy);
            }
            catch (Exception)
            {
                MessageBox.Show("Você não colocou um valor valido. Pfv tente de outra maneira", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Valortxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);             
            }

        }
    }
}
