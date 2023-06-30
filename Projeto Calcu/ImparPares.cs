using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Calcu
{
    public partial class ImparPares : Form
    {
        private PictureBox pictureBox1;

        public ImparPares()
        {
            InitializeComponent();

            // Crie um controle PictureBox
            pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(100, 100);
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Adicione o controle PictureBox ao formulário
            this.Controls.Add(pictureBox1);
        }

        private void number_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)number.Value;

            if (x % 2 == 0)
            {
                txt_resultado.Text = "Par";
                pictureBox1.Image = Image.FromFile("C:\\Users\\joan.ldbarbosa\\source\\repos\\Projeto Calcu\\Projeto Calcu\\img\\gato.jpg");
            }
            else
            {
                txt_resultado.Text = "Ímpar";
                pictureBox1.Image = Image.FromFile("C:\\Users\\joan.ldbarbosa\\source\\repos\\Projeto Calcu\\Projeto Calcu\\img\\gato-feliz-1.jpg");
            }
        }
    }
}
