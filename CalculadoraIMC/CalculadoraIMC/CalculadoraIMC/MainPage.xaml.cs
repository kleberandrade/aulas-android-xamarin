using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um nome", "OK");
                return;
            }

            if (string.IsNullOrEmpty(pesoEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um peso", "OK");
                return;
            }

            if (string.IsNullOrEmpty(alturaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar uma altura", "OK");
                return;
            }

            string nome = nomeEntry.Text;
            double peso = Convert.ToDouble(pesoEntry.Text);
            double altura = Convert.ToDouble(alturaEntry.Text);

            double imc = peso / (altura * altura);
            // Titulo, Mensagem, Options
            DisplayAlert("Resultado",  
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}",              
                "OK");

        }
    }
}
