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

namespace Projeto_Calcu
{
    
    public partial class Calculadora : Form
    {   
        decimal val1 = 0, val2 = 0;
        string opcao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            val1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            txt_Resultado.Text = "";
            opcao = "MULTI";
            lbl_Operacao.Text = "x";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "3";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToInt16(txt_Resultado.Text, CultureInfo.InvariantCulture);
            

            if(opcao == "SOMA")
            {
                txt_Resultado.Text = Convert.ToString(val1 + val2);
                txt_operacao.Text = "SOMA";
            }
            else if(opcao == "SUBTRAÇÃO")
            {
                txt_Resultado.Text = "" + Convert.ToString(val1 - val2);
                txt_operacao.Text = "SUBTRAÇÃO";
            }
            else if (opcao == "DIV")
            {
                txt_Resultado.Text = Convert.ToString(""+val1 / val2);
                txt_operacao.Text = "DIVISÃO";
            }
            else if (opcao == "MULTI")
            {
                txt_Resultado.Text = Convert.ToString(val1 * val2);
                txt_operacao.Text = "MULTIPLICAÇÃO";
            }
            else if (opcao == "")
            {
                txt_operacao.Text = "ESCOLHA UMA OPERAÇÃO";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            val1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
            val2 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);


            txt_Resultado.Text = "";
            opcao = "DIV";
            lbl_Operacao.Text = "/";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txt_Resultado.Text += "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text += "-";

            val1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            txt_Resultado.Text = "";
            opcao = "SUBTRAÇÃO";
            lbl_Operacao.Text = "-";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Resultado.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            val1 = decimal.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            txt_Resultado.Text = "";
            opcao = "SOMA";
            lbl_Operacao.Text = "+"; 
        }
    }
}
