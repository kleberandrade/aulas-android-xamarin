using SQLite;
using System;

namespace EmprestimoObjetos.Models
{ 
    public class ObjetoEmprestado
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public override bool Equals(object obj)
        {
            var objetoEmprestado = obj as ObjetoEmprestado;
            if (objetoEmprestado == null)
            {
                return false;
            }

            return Id.Equals(objetoEmprestado.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Contains(String texto)
        {
            return Nome.ToLower().Contains(texto.ToLower()) || Descricao.ToLower().Contains(texto.ToLower());
        }
    }
}