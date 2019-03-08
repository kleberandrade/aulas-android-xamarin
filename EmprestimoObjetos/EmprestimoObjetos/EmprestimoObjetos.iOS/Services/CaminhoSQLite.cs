using EmprestimoObjetos.iOS.Services;
using EmprestimoObjetos.Services;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(CaminhoSQLite))]
namespace EmprestimoObjetos.iOS.Services
{
    public class CaminhoSQLite : ICaminhoSQLite
    {
        public string GetCaminhoDB(string dbName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, dbName);
        }
    }
}