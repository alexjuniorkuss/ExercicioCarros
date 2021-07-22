using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Pecas : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public Pecas() { }
        public Pecas(int id, string nome, string descricao, decimal valor) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
        }
        public override string ToString()
        {
            return ($"Id: {this.Id}\t Peça: {this.Nome}\tValor: {this.Valor}" +
                $"\nDescrição: {this.Descricao}");
        }
    }
}
