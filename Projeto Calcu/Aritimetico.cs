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
    public partial class Aritimetico : Form
    {
        int valo1 = 0;
        int valo2 = 0;
        int valo3 = 0;
        double resultado = 0;

        public Aritimetico()
        {
            InitializeComponent();
        }

        private void txt_pri_TextChanged(object sender, EventArgs e)
        {
            valo1 = Convert.ToInt32(txt_pri.Text);
        }

        private void txt_seg_TextChanged(object sender, EventArgs e)
        {
            valo2 = Convert.ToInt32(txt_seg.Text);
        }

        private void txt_ter_TextChanged(object sender, EventArgs e)
        {
            valo3 = Convert.ToInt32(txt_ter.Text);
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            int soma = valo1 + valo2 + valo3;
            resultado = (double)soma / 3;
            txt_resultado.Text = resultado.ToString();
        }
    }
}
