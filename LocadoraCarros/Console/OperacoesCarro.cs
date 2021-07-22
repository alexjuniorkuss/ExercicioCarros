using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace ViewConsole
{
    public class OperacoesCarro : Crud
    {
        int idCar = 1;
        public OperacoesCarro()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }
        private void Cadastrar()
        {
            Console.WriteLine($"Cadastrando {idCar}º Carro");
            Carro carroC = new Carro();
            CadastroEdita(carroC);
            carroC.Id = lista.Count() + 1;
            idCar++;
            lista.Add(carroC);
        }
            
        private static void CadastroEdita(Carro carro)
        {
            Console.WriteLine("Nome do Carro:");
            carro.Nome = Console.ReadLine().Trim();
            Console.WriteLine("Modelo:");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Descrição:");
            carro.Descricao = Console.ReadLine();
        }
        private void Listar()
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("\t\t\t Lista de Carros\n");
                foreach (Carro carroL in lista)
                {
                    Console.WriteLine(carroL.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum Carro Cadastrado!");
            }
            PausarImpressao();
        }
        private void Alterar()
        {
            Listar();
            int id = ProcuraId();
            var carroU = (Carro)lista.Find(p => p.Id == id);
            CadastroEdita(carroU);
            Console.WriteLine("Cadastro alterado com sucesso!");
            Console.ReadLine();
        }
        private static int ProcuraId()
        {
            Console.WriteLine("Selecione o Id desejada:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        private void Deletar()
        {
            Listar();
            int id = ProcuraId();
            var carro = lista.Find(p => p.Id == id);
            lista.Remove(carro);
        }
    }
}
