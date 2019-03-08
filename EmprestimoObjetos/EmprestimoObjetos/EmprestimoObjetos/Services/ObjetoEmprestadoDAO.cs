using EmprestimoObjetos.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace EmprestimoObjetos.Services
{
    public class ObjetoEmprestadoDAO
    {
        private SQLiteConnection conexao;

        public ObjetoEmprestadoDAO()
        {
            string camimnho = DependencyService.Get<ICaminhoSQLite>().GetCaminhoDB("database.sqlite");
            conexao = new SQLiteConnection(camimnho);

            conexao.CreateTable<ObjetoEmprestado>();
        }

        public List<ObjetoEmprestado> GetTodos()
        {
            return (from data in conexao.Table<ObjetoEmprestado>()
                    select data).ToList();
        }

        public ObjetoEmprestado Get(int id)
        {
            return conexao.Table<ObjetoEmprestado>().FirstOrDefault(t => t.Id == id);
        }

        public void ExcluirTodos()
        {
            conexao.DeleteAll<ObjetoEmprestado>();
        }

        public void ExluirPorId(int id)
        {
            conexao.Delete<ObjetoEmprestado>(id);
        }

        public void Adicionar(ObjetoEmprestado objetoEmprestado)
        {
            conexao.Insert(objetoEmprestado);
        }

        public void Atualizar(ObjetoEmprestado objetoEmprestado)
        {
            conexao.Update(objetoEmprestado);
        }
    }
}
