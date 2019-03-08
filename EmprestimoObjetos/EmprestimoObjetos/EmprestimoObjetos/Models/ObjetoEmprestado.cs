using SQLite;
using System;

namespace EmprestimoObjetos.Models
{ 
    public class ObjetoEmprestado
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Decricao { get; set; }

        public DateTime Data { get; set; }

        public override bool Equals(object obj)
        {
            ObjetoEmprestado objetoEmprestado = obj as ObjetoEmprestado;
            if (objetoEmprestado == null)
                return false;

            return Id.Equals(objetoEmprestado.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
