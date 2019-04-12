using EmprestimoObjetos.Models;
using EmprestimoObjetos.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmprestimoObjetos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroObjetoEmprestadoPage : ContentPage
	{
        private ObjetoEmprestado objetoEmprestado;

		public CadastroObjetoEmprestadoPage (bool isEdit, ObjetoEmprestado objetoEmprestado)
		{
			InitializeComponent ();

            Data.Date = DateTime.Now;

            SalvarButton.IsVisible = !isEdit;
            AtualizarButton.IsVisible = isEdit;
            ExcluirButton.IsVisible = isEdit;

            if (objetoEmprestado != null)
            {
                this.objetoEmprestado = objetoEmprestado;
                Descricao.Text = objetoEmprestado.Descricao;
                Nome.Text = objetoEmprestado.Nome;
                Data.Date = objetoEmprestado.Data;
                Title = "Editar Objeto Emprestado";
            }
            else
            {
                Title = "Novo Objeto Emprestado";
            }
        }

        private void OnSalvarObjetoEmprestado(object sender, EventArgs e)
        {
            objetoEmprestado = new ObjetoEmprestado();
            objetoEmprestado.Nome = Nome.Text;
            objetoEmprestado.Descricao = Descricao.Text;
            objetoEmprestado.Data = Data.Date;

            ObjetoEmprestadoDAO dao = new ObjetoEmprestadoDAO();
            dao.Adicionar(objetoEmprestado);

            Navigation.PopAsync();
        }

        private void OnAtualizarObjetoEmprestado(object sender, EventArgs e)
        {
            objetoEmprestado.Nome = Nome.Text;
            objetoEmprestado.Descricao = Descricao.Text;
            objetoEmprestado.Data = Data.Date;

            ObjetoEmprestadoDAO dao = new ObjetoEmprestadoDAO();
            dao.Atualizar(objetoEmprestado);

            Navigation.PopAsync();
        }

        private void OnExcluirObjetoEmprestado(object sender, EventArgs e)
        {
            ObjetoEmprestadoDAO dao = new ObjetoEmprestadoDAO();
            dao.ExluirPorId(objetoEmprestado.Id);

            Navigation.PopAsync();
        }
    }
}