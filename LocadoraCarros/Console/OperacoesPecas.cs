using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace ViewConsole
{
    public class OperacoesPecas : Crud
    {
        int idPec = 1;
        public OperacoesPecas()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.updateOperation = Deletar;
        }
        private void Cadastrar()
        {
            Console.WriteLine($"Cadastrando {idPec}o Peça.");
            Pecas pecasC = new Pecas();
            CadastroEdita(pecasC);
            pecasC.Id = lista.Count() + 1;
            lista.Add(pecasC);
        }
        private static void CadastroEdita(Pecas peca)
        {
            Console.WriteLine("Nome da Peça:");
            peca.Nome = Console.ReadLine().Trim();
            Console.WriteLine("Descriçaõ:");
            peca.Descricao = Console.ReadLine();
            Console.WriteLine("Valor:");
            peca.Valor = Convert.ToDecimal(Console.ReadLine());
        }
        private void Listar()
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("\t\t\t Lista de Pecas\n");
                foreach (Pecas pecasL in lista)
                {
                    Console.WriteLine(pecasL.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma Peça Cadastrada!");
            }
            PausarImpressao();
        }
        private void Alterar()
        {
            Listar();
            int id = ProcuraId();
            var PecaU = (Pecas)lista.Find(p => p.Id == id);
            CadastroEdita(PecaU);
            Console.WriteLine("Cadastro alterado com sucesso!");
            Console.ReadLine();
        }
        private static int ProcuraId()
        {
            Console.WriteLine("Selecione a Id desejada:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        private void Deletar()
        {
            Listar();
            int id = ProcuraId();
            var peca = lista.Find(p => p.Id == id);
            lista.Remove(peca);
        }
    }
}
