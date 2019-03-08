using EmprestimoObjetos.Droid.Services;
using EmprestimoObjetos.Services;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(CaminhoSQLite))]
namespace EmprestimoObjetos.Droid.Services
{
    public class CaminhoSQLite : ICaminhoSQLite
    {
        public string GetCaminhoDB(string dbName)
        {
            string caminhoPasta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(caminhoPasta, dbName);
        }
    }
}