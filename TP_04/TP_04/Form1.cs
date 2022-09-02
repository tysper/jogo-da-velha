using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP_04
{
    public partial class FRM_Main : Form
    {

        #region Variáveis Globais
        //Controle de estado
        int numero_partida = 1;
        PictureBox[] posicoes = new PictureBox[9];
        bool[] posicoes_usadas = { false, false, false, false, false, false, false, false, false };
        //Definir as posicoes favoraveis para cada jogada
        /*int[] posicao1 = { 0, 3, 6 };
        int[] posicao2 = { 1, 4, 7 };
        int[] posicao3 = { 2, 5, 8 };
        int[] posicao4 = { 0, 1, 2 };
        int[] posicao5 = { 3, 4, 5 };
        int[] posicao6 = { 6, 7, 8 };
        int[] posicao7 = { 0, 4, 8 };
        int[] posicao8 = { 2, 4, 6 };*/
        int[,,] posicoes_favoraveis = new int[9, 4, 3]
        {
            //Iterar pela posicao correspondente e achar qual posicao tem um score maior de ganhar, desse jeito o computador
            //encontra a melhor posicao que ainda não foi usada;
            {//0 
                { 0, 3, 6 }, { 0, 1, 2 }, { 0, 4, 8 }, {-1, -1, -1}
            },
            {//1
                { 1, 4, 7 }, { 0, 1, 2 }, {-1, -1, -1}, {-1, -1, -1}
            },
            {//2
                { 2, 5, 8 }, { 0, 1, 2 }, { 2, 4, 6 }, {-1, -1, -1}
            },
            {//3
                { 0, 3, 6 }, { 3, 4, 5 }, {-1, -1, -1}, {-1, -1, -1}
            },
            {//4
                { 1, 4, 7 }, { 3, 4, 5 }, { 0, 4, 8 }, { 2, 4, 6 }
            },
            {//5
                { 2, 5, 8 }, { 3, 4, 5 }, {-1, -1, -1}, {-1, -1, -1}
            },
            {//6
                { 0, 3, 6 }, { 6, 7, 8 }, { 2, 4, 6 }, {-1, -1, -1}
            },
            {//7
                { 1, 4, 7 }, { 6, 7, 8 }, {-1, -1, -1},  {-1, -1, -1}
            },
            {//8
                { 2, 5, 8 }, { 6, 7, 8 }, { 0, 4, 8 }, {-1, -1, -1}
            }
        };
  

        //Messagem para o usuário
        String msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton botao_padrao;
        #endregion

        #region Funções
        
        //Iniciar posicoes com os elementos do FORM
        void inicializar_espacos()
        {
            posicoes[0] = ESP_0;
            posicoes[1] = ESP_1;
            posicoes[2] = ESP_2;
            posicoes[3] = ESP_3;
            posicoes[4] = ESP_4;
            posicoes[5] = ESP_5;
            posicoes[6] = ESP_6;
            posicoes[7] = ESP_7;
            posicoes[8] = ESP_8;
        }

        //Verificar se o espaco já foi usado e senão aplicar a imagem correspondente, e armazenar que a posicao ja foi usada
        void mudar_imagem(int pos, string player)
        {
            if(!posicoes_usadas[pos])
            {
                if(player == "jogador")
                {
                    posicoes[pos].Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\nemo.png");
                } else if(player == "pc")
                {
                    posicoes[pos].Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\dory.png");
                }
                posicoes[pos].BackColor = Color.Transparent;
                posicoes_usadas[pos] = true;
            }
        }

        //Escolhe um numero aleátorio
        int numero_aleatorio(int min, int max)
        {
            Random sorteio = new Random();
            int x = sorteio.Next(min, max*100);
            return (x % max);
        }

        #endregion 

        public FRM_Main()
        {
            InitializeComponent();
            inicializar_espacos();
        }


        private void FRM_Main_Load(object sender, EventArgs e)
        {

        }

        private void TXT_Nome_TextChanged(object sender, EventArgs e)
        {
            GRP_Partida.Text = "Partida " + numero_partida + " - " + TXT_Nome.Text;
            GRP_Placar.Text = "Placar de " + TXT_Nome.Text;
        }

        #region Lixo

        #region Posições
        private void ESP_0_MouseClick(object sender, MouseEventArgs e)
        {
            mudar_imagem(0, "jogador");
        }

        private void ESP_1_Click(object sender, EventArgs e)
        {
            mudar_imagem(1, "jogador");
        }

        private void ESP_2_Click(object sender, EventArgs e)
        {
            mudar_imagem(2, "jogador");
        }

        private void ESP_3_Click(object sender, EventArgs e)
        {
            mudar_imagem(3, "jogador");
        }

        private void ESP_4_Click(object sender, EventArgs e)
        {
            mudar_imagem(4, "jogador");
        }

        private void ESP_5_Click(object sender, EventArgs e)
        {
            mudar_imagem(5, "jogador");
        }

        private void ESP_6_Click(object sender, EventArgs e)
        {
            mudar_imagem(6, "jogador");
        }

        private void ESP_7_Click(object sender, EventArgs e)
        {
            mudar_imagem(7, "jogador");
        }

        private void ESP_8_Click(object sender, EventArgs e)
        {
            mudar_imagem(8, "jogador");
        }

        #endregion
        #region Sair
        private void button2_Click(object sender, EventArgs e)
        {
            msg = "Tem certeza? Seu placar atual será perdido...";
            titulo = "Sair";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            botao_padrao = MessageBoxDefaultButton.Button2;
            if(MessageBox.Show(msg, titulo, botoes, icone, botao_padrao)==DialogResult.Yes)
            {
                this.Close();
            }


        }
        #endregion


        private void BTN_Reiniciar_Click(object sender, EventArgs e)
        {
            LBL_Venceu.Text = Convert.ToString(numero_aleatorio(0, 8));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
