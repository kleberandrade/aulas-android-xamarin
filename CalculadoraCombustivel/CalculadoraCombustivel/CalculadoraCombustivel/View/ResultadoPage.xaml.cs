using CalculadoraCombustivel.Model;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraCombustivel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultadoPage : ContentPage
	{
		public ResultadoPage (Combustivel etanol, Combustivel gasolina)
		{
			InitializeComponent ();

            precoEtanolLabel.Text =  etanol.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            precoGasolinaLabel.Text = gasolina.Preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            consumoEtanolLabel.Text = $"{etanol.Consumo.ToString("0.00")} km/litro";
            consumoGasolinaLabel.Text = $"{gasolina.Consumo.ToString("0.00")} km/litro";

            double relacaoEtanolGasolina = etanol.Preco / gasolina.Preco * 100.0;
            double gastoEtanol = etanol.Gasto();
            double gastoGasolina = gasolina.Gasto();
            double economia = Math.Abs(gastoEtanol - gastoGasolina);

            relacaoEtanolGasolinaLabel.Text = $"{relacaoEtanolGasolina.ToString("0.00")} %";
            gastoEtanolLabel.Text = gastoEtanol.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " por km";
            gastoGasolinaLabel.Text = gastoGasolina.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " por km";

            abastecaComResultadoLabel.Text = "Abasteça com " + (gastoEtanol < gastoGasolina ? "ETANOL" : "GASOLINA");
            economiaLabel.Text = $"Sua economia será de {economia.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} por km";
        }

        private void OnVoltar(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}