using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindosFormGasto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //entrada 
            double renda = double.Parse(txtRenda.Text);

            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double inter = double.Parse(txtInter.Text);
            double alimento = double.Parse(txtAlimento.Text);
            double outros = double.Parse(txtOutros.Text);

            //processamento 
            double gastos = energia + agua + inter + alimento + outros;

            double saldo = renda - gastos; 

            //Saída
            lblGastos.Text = gastos.ToString();
            lblSaldo.Text = saldo.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtRenda.Clear();
            txtEnergia.Clear();
            txtInter.Clear();
            txtAlimento.Clear();
            txtOutros.Clear();
            txtAgua.Clear();

            lblGastos.Text = "0";
            lblSaldo.Text = "0";

        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
