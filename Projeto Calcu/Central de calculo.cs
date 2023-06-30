using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calcu
{
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        private void Central_Load(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imparOuParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImparPares number = new ImparPares();
            number.ShowDialog();
        }

        private void calculoDeMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aritimetico ari = new Aritimetico();
            ari.ShowDialog();
        }
    }
}
