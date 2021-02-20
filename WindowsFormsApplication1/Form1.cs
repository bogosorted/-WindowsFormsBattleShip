using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtNv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 jg = new Form2();
            button1.Text ="Outra tentativa?";
            jg.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicialmente, jogador terá que escolher a posição dos seus quatro navios clicando nos botões da tabela. Quem conseguir o maior abate de navios em um ciclo de 10 rodadas vence. Os inimigos podem ganhar pontos pela demora da jogada do jogador, assim , o jogo terá alguma dificuldade. ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
