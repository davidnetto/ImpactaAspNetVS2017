using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);

            decimal valorPago   = Convert.ToDecimal(valorPagoTextBox.Text);

            decimal troco = valorPago - valorCompra;

            //letra c serve para o vs saber que eh moedas o numero e de casas decimas
            TrocoTextBox.Text = troco.ToString("c2");

            //ToDo:refatorar para usar estrututras de repetição

            //seria como um truncamento, a parte decimal eh jogada fora
            int moedas1 = (int)troco;

            // troco = troco % 1; é a mesma coisa que troco %=1;
            troco %= 1;

            // letra m é para forçar a ser decimal pq estamos trabalhando com dinheiro
            int moedas050 = (int)(troco / 0.5m);
            troco %= 0.5m;

            int moedas025 = (int)(troco / 0.25m);
            troco %= 0.25m;

            int moedas010 = (int)(troco / 0.1m);
            troco %= 0.1m;

            int moedas005 = (int)(troco / 0.05m);
            troco %= 0.05m;

            int moedas001 = (int)(troco / 0.01m);
            troco %= 0.01m;

            

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas050.ToString();
            moedasListView.Items[2].Text = moedas025.ToString();
            moedasListView.Items[3].Text = moedas010.ToString();
            moedasListView.Items[4].Text = moedas005.ToString();
            moedasListView.Items[5].Text = moedas001.ToString();
        }
    }
}
