using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarcadorTruco
{
    public partial class MainPage : ContentPage
    {
        private int pontosJogador1, pontosJogador2;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnComputarPontoJogador1(object sender, EventArgs e)
        {
            //Button botaoClicado = sender as Button;
            Button botaoClicado = (Button)sender;
            string textoDoBotaoClicado = botaoClicado.Text;
            int pontos = int.Parse(textoDoBotaoClicado);
            //pontosJogador1 = pontosJogador1 + pontos;
            pontosJogador1 += pontos;
            jogador1Label.Text = pontosJogador1.ToString();

            if (pontosJogador1 >= 12)
            {
                 DisplayAlert("Fim do Jogo", 
                              $"Nós ganhamos de {pontosJogador1} x {pontosJogador2}",
                              "OK");

                OnNovoJogo(this, null);
            }
        }

        private void OnComputarPontoJogador2(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoDoBotaoClicado = botaoClicado.Text;
            int pontos = int.Parse(textoDoBotaoClicado);
            pontosJogador2 += pontos;
            jogador2Label.Text = pontosJogador2.ToString();

            if (pontosJogador2 >= 12)
            {
                DisplayAlert("Fim do Jogo",
                    $"Eles ganharam de {pontosJogador2} x {pontosJogador1}",
                    "OK");

                OnNovoJogo(this, null);
            }
        }

        private void OnNovoJogo(object sender, EventArgs e)
        {
            pontosJogador1 = 0;
            jogador1Label.Text = pontosJogador1.ToString();
            pontosJogador2 = 0;
            jogador2Label.Text = "0";
        }
    }
}
