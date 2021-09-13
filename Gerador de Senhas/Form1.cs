using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Senhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            escrevernaimagem();
        }
        private void escrevernaimagem()
        {
            var imagem = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            // Irá criar um mapa de bits nos tamanhos específicados, no caso é a altura e comprimento da janela de texto.
            var fonte = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            // Define o tipo, tamanho e como a fonte será usada.
            var graficos = Graphics.FromImage(imagem);
            // Comprime um desenho em um texto.
            graficos.DrawString(Gerador.Senhas(), fonte, Brushes.Black, new Point(0, 0));
            // Desenha o texto na caixa de texto.
            this.pictureBox1.Image = imagem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            escrevernaimagem();
            // Quando o botão for clicado a senha será gerada.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
