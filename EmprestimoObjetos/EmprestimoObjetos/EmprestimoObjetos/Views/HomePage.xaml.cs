using EmprestimoObjetos.Models;
using EmprestimoObjetos.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmprestimoObjetos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        private ObservableCollection<ObjetoEmprestado> objetosEmprestados;

        public HomePage ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            objetosEmprestados = GetObjetosEmprestados();
            ObjetoEmprestadoListView.ItemsSource = objetosEmprestados;
            base.OnAppearing();
        }

        public ObservableCollection<ObjetoEmprestado> GetObjetosEmprestados()
        {
            ObjetoEmprestadoDAO dao = new ObjetoEmprestadoDAO();
            return new ObservableCollection<ObjetoEmprestado>(dao.GetTodos());
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = ObjetoEmprestadoSearchBar.Text;
            ObjetoEmprestadoListView.ItemsSource = objetosEmprestados.Where(x => x.Contains(texto));
        }

        private void OnItemSelecionado(object sender, SelectedItemChangedEventArgs e)
        {
            ObjetoEmprestado objetoEmprestado = e.SelectedItem as ObjetoEmprestado;
            Navigation.PushAsync(new CadastroObjetoEmprestadoPage(true, objetoEmprestado));

        }

        private void OnAdicionarNovoObjetoEmprestado(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroObjetoEmprestadoPage(false, null));
        }
    }
}