using EmprestimoObjetos.Services;
using EmprestimoObjetos.UWP.Services;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(CaminhoSQLite))]
namespace EmprestimoObjetos.UWP.Services
{
    public class CaminhoSQLite : ICaminhoSQLite
    {
        public string GetCaminhoDB(string dbName)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
        }
    }
}