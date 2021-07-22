using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Carro : BaseModel
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Descricao { get; set; }
        public Carro() { }
        public Carro(int id, string nome, string marca, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Modelo = marca;
            this.Descricao = descricao;
        }
        public override string ToString()
        {
            return ($"Id: {this.Id}\tCarro: {this.Nome}\tMarca: {this.Modelo}\n" +
                $"Descrição: {this.Descricao}");
        }
    }
}
