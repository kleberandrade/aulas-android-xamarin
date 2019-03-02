using System;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        private string operador ="";
        private double numero1;
        private double numero2;

        public MainPage()
        {
            InitializeComponent();
            OnLimpar(this, null);
        }

        private void OnLimpar(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = "";
            resultadoLabel.Text = "0";
        }

        private void OnNumeroSelecionado(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string textoBotao = botao.Text;

            if (resultadoLabel.Text.Length == 14)
                return;

            resultadoLabel.Text += textoBotao;

            double numero;
            if (double.TryParse(resultadoLabel.Text, out numero))
            {
                resultadoLabel.Text = numero.ToString("N0");
                if (operador.Length == 0)
                    numero1 = numero;
                else
                    numero2 = numero;
            }
        }

        private void OnApagar(object sender, EventArgs e)
        {
            int tamanho = resultadoLabel.Text.Length;
            resultadoLabel.Text = resultadoLabel.Text.Remove(tamanho - 1);
            if (resultadoLabel.Text.Length == 0)
                resultadoLabel.Text = "0";
        }

        private void OnOperadorSelecionado(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            operador = botao.Text;
            resultadoLabel.Text = "0";
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            double resultado = 0;

            if (operador == "+")
                resultado = numero1 + numero2;
            if (operador == "-")
                resultado = numero1 - numero2;
            if (operador == "x")
                resultado = numero1 * numero2;
            if (operador == "/")
                resultado = numero1 / numero2;

            resultadoLabel.Text = resultado.ToString("N0");
            numero1 = resultado;
            operador = "";
        }
    }
}
