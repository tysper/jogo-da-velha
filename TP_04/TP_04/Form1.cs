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
using System.Runtime.CompilerServices;

namespace TP_04
{
    public partial class FRM_Main : Form
    {

        #region Variáveis Globais
        //Controle de estado
        
        int contagemPartida = 1;
        bool jogoAcabou = false;
        PictureBox[] camposBranco = new PictureBox[9];
        //controla as posicoes usadas por cada jogador
        string[] posicoesUsadas = new string[9] { "", "", "", "", "", "", "", "", ""};
        
        bool esperarJogada = false;
        int numeroJogadas = 0;
        string ganhadorFinal;
        //placar
        int empates = 0;
        int ganhos = 0;
        int perdas = 0;
        string fotoJogador = "\\stitch.png", fotoPc = "\\lilo.png";

        //Messagem para o usuário
        String msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton botao_padrao;
        #endregion

        #region Funções
        //Iniciar posicoes com os espacos em branco para lidar de uma maneira mais facil depois
        void inicializar_espacos()
        {
            camposBranco[0] = ESP_0;
            camposBranco[1] = ESP_1;
            camposBranco[2] = ESP_2;
            camposBranco[3] = ESP_3;
            camposBranco[4] = ESP_4;
            camposBranco[5] = ESP_5;
            camposBranco[6] = ESP_6;
            camposBranco[7] = ESP_7;
            camposBranco[8] = ESP_8;
        }

        //Reinicia o jogo sem perder o score
        void prox_jogo()
        {
            jogoAcabou = false;
            esperarJogada = false;
            numeroJogadas = 0;
            ganhadorFinal = "";
            for(int i = 0; i < 9; i++)
            {
                camposBranco[i].Image = null;
                camposBranco[i].BackColor = Color.AliceBlue;
                posicoesUsadas[i] = "";
            }
                
        }

        //Reincia todas as variávei para o zero tirando o placar
        void reiniciar_tudo()
        {
            prox_jogo();
            contagemPartida = 1;
            empates = 0;
            ganhos = 0;
            perdas = 0;
            atualizar_LBL();
        }

        //Verifica se o jogo acabou
        bool jogo_acabou()
        {
            if(numeroJogadas == 9)
            {
                return true;
            }
            return false;
        }


        //verifica se alguem ganhou
        bool resultado()
        {
            //define as formas de ganhar
            string[] ganhador = new string[8] { "123", "456", "789", "147", "258", "369", "159", "357" };
            bool ganhou = false;
            //algoritmo para verificar se alguem ganhou
            for(int i = 0; i < 8; i++)
            {
                int min = (ganhador[i][0] - '0') - 1;
                int max = ganhador[i][2] - '0';
                string esp1 = "", esp2 = "", esp3 = "";
                ganhadorFinal = "";
                //horizontal
                if(max - min == 3)
                {
                    esp1 = posicoesUsadas[min];
                    esp2 = posicoesUsadas[min + 1];
                    esp3 = posicoesUsadas[min + 2];
                    ganhadorFinal = esp1;
                 //vertical
                }
                else if(max - min == 7)
                {
                    esp1 = posicoesUsadas[min];
                    esp2 = posicoesUsadas[min + 3];
                    esp3 = posicoesUsadas[min + 6];
                    ganhadorFinal = esp1; 
                 //inclinado
                } else if(max - min == 9)
                {
                    esp1 = posicoesUsadas[min];
                    esp2 = posicoesUsadas[min + 4];
                    esp3 = posicoesUsadas[min + 8];
                    ganhadorFinal = esp1;
                }
                else if(max - min == 5)
                {
                    esp1 = posicoesUsadas[min];
                    esp2 = posicoesUsadas[min + 2];
                    esp3 = posicoesUsadas[min + 4];
                    ganhadorFinal = esp1;
                }
                //Atualiza a pontuação e o estado do jogo
                if (esp1 == esp2 && esp1 != "")
                {
                    if (esp2 == esp3)
                    {
                        ganhou = true;
                        atualizar_LBL();
                        break;
                    }
                } else
                {
                    ganhadorFinal = "";
                }
            }
            return ganhou;
        }

        //Atualizar foto de perfil e dos jogadores de acordo com a opcao selecionada
        void atualizar_foto(int personagem)
        {
            switch(personagem)
            {
                case 0:
                    fotoJogador = "\\stitch.png";
                    fotoPc = "\\lilo.png";
                    break;
                case 1:
                    fotoJogador = "\\nemo.png";
                    fotoPc = "\\dory.png";
                    break;
                case 2:
                    fotoJogador = "\\yoda.png";
                    fotoPc = "\\kyle.png";
                    break;
                case 3:
                    fotoJogador = "\\peter.png";
                    fotoPc = "\\thanos.png";
                    break;

            }
            PCT_Perfil.Image = Image.FromFile(Directory.GetCurrentDirectory() + fotoJogador);
            for (int i = 0; i < 9; i++)
            {
                if (posicoesUsadas[i] == "pc")
                {
                    camposBranco[i].Image = Image.FromFile(Directory.GetCurrentDirectory() + fotoPc);
                } else if (posicoesUsadas[i] == "jogador")
                {
                    camposBranco[i].Image = Image.FromFile(Directory.GetCurrentDirectory() + fotoJogador);
                }
            }
        }

        //Verifica se ja teve algum empate
        bool empate()
        {
            if(numeroJogadas == 9)
            {
                if(!resultado())
                {
                    if(!jogoAcabou)
                    {
                        empates++;
                        jogoAcabou = true;
                    }
                    return true;
                }
            }
            return false;
        }

        //Atualiza o placar com os numero atuais
        void atualizar_LBL()
        {
            LBL_Empatou.Text = "Empatou: " + empates;
            LBL_Perdeu.Text = "Perdeu: " + perdas;
            LBL_Venceu.Text = "Venceu: " + ganhos;
        }

        //Verificar se o espaco clicado já foi usado e senão aplicar a imagem correspondente,
        //e armazenar que a posicao ja foi usada pelo player ou computador
        bool mudar_imagem(int pos, string player)
        {
            //se a posicao não tiver sido usada
            if(posicoesUsadas[pos] == "")
            {
                // se quem jogou foi a pessoa, e o pc nao ta "pensando", nao teve nenhum empate e ninguem ganhou
                if(player == "jogador" && !esperarJogada && !empate() && !resultado())
                {
                    //muda a imagem
                    camposBranco[pos].Image = Image.FromFile(Directory.GetCurrentDirectory() + fotoJogador);
                    camposBranco[pos].BackColor = Color.Transparent;
                    posicoesUsadas[pos] = player;
                    numeroJogadas++;
                    //se o jogo nao acabou fazer o pc procurar uma nova jogada
                    if(!jogoAcabou)
                    { 
                    jogada_pc();
                    }
                } else if(player == "pc" && !esperarJogada && !empate() && !resultado())
                {
                    //se ainda nao tiver sido usada a jogada será aplicada
                    camposBranco[pos].Image = Image.FromFile(Directory.GetCurrentDirectory() + fotoPc);
                    camposBranco[pos].BackColor = Color.Transparent;
                    posicoesUsadas[pos] = player;
                    numeroJogadas++;
                }
                //se alguem ganhar
                if (resultado())
                {
                    //Atualizar variaveis do placar
                    jogoAcabou = true;
                    if(ganhadorFinal == "pc")
                    {
                        perdas++;
                    } else if(ganhadorFinal == "jogador")
                    {
                        ganhos++;
                    }
                };
                //checar por empate
                empate();
                //atualizar placar
                atualizar_LBL();
                //mostrar mensagem para permitir o jogador ir para o prox jogo
                if(jogoAcabou)
                {
                    titulo = !empate()? "Você " + (ganhadorFinal == "jogador"? "Ganhou": "Perdeu"): "Ninguém Ganhou";
                    msg = "A partida acabou, gostaria de jogar denovo?";
                    botoes = MessageBoxButtons.YesNo;
                    icone = MessageBoxIcon.Question;
                    botao_padrao = MessageBoxDefaultButton.Button1;
                    if(MessageBox.Show(msg, titulo, botoes, icone, botao_padrao)==DialogResult.Yes)
                    {
                        contagemPartida++;
                        prox_jogo();
                    } else
                    {
                        this.Close();
                    }

                }
                return true;
            }
            return false;
        }

        //Escolhe um numero aleátorio
        int numero_aleatorio(int min, int max)
        {
            Random sorteio = new Random();
            int x = sorteio.Next(min, max*100);
            return (x % max);
        }

        //uma função assincrona para dar impressao que o computador esta "pensando"
        async void jogada_pc()
        {
            //ajuda a controlar se o jogador pode clicar em outro espaco enquanto o computador "pensa"
            esperarJogada = true;
            await Task.Delay(1000);
            if(!jogoAcabou)
            {
               while(!mudar_imagem(numero_aleatorio(0, 9), "pc"));
            }
            esperarJogada = false;
        }
        #endregion

        #region Carregamento Principal
        public FRM_Main()
        {
            InitializeComponent();
            inicializar_espacos();
        }
        #endregion

        #region Mudar texto
        //muda o texto dos groupfields ao mudar o texto do textbox
        private void TXT_Nome_TextChanged(object sender, EventArgs e)
        {
            GRP_Partida.Text = "Partida " + contagemPartida + " - " + TXT_Nome.Text;
            GRP_Placar.Text = "Placar de " + TXT_Nome.Text;
        }
        #endregion

        #region Botão Jogo
        //espaços para o jogador realizar seu movimento
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

        #region Botão Reiniciar
        //reinicia o programa por completo
        private void BTN_Reiniciar_Click(object sender, EventArgs e)
        {
            titulo = "Reiniciar toda partida";
            msg = "Seu placar atual será perdido e apagado";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            botao_padrao = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, botao_padrao) == DialogResult.Yes)
            {
                reiniciar_tudo();
            }
        }
        #endregion

        #region Botão Sair
        //sai do programa
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

        #region Personagem
        //muda a foto dos personagens
        private void BTN_Stitch_Click(object sender, EventArgs e)
        {
            atualizar_foto(0);
        }

        private void BTN_Nemo_Click(object sender, EventArgs e)
        {
            atualizar_foto(1);
        }

        private void BTN_Yoda_Click(object sender, EventArgs e)
        {
            atualizar_foto(2);
        }

        private void BTN_Peter_Click(object sender, EventArgs e)
        {
            atualizar_foto(3);
        }
        #endregion
        
        
        
        #region Lixo
        private void FRM_Main_Load(object sender, EventArgs e)
        {

        }


        private void GRP_Partida_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
