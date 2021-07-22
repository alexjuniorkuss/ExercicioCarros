using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class ModuloCarro : Tela
    {
        OperacoesCarro crud = new OperacoesCarro();
        public ModuloCarro(): base("      Carro     ")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        private void Escolha(int escolha)
        {
            string resp = "";
            Console.Clear();
            this.Cabecalho();
            switch (escolha)
            {
                case 1:
                    do
                    {
                         Console.Clear();
                        this.Cabecalho();
                        crud.Create();
                        Console.WriteLine("Deseja Cadastrar mais um Carro?");
                        resp = Console.ReadLine();
                    } while (resp == "s");
                    break;
                case 2:
                    crud.Update();
                    break;
                case 3:
                    crud.Delete();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] -Cadastrar" +
                            "\n[2] -Listar" +
                            "\n[3] -Editar" +
                            "\n[4] -Deletar" +
                            "\n[0] -Sair");
            Console.WriteLine("*************************************************");
            Console.Write("Digite uma Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
    }
}
