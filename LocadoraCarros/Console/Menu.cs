using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Menu : Tela
    {
        private ModuloCarro modCarro;
        private ModuloPecas modPecas;
        public Menu(): base("    Bem-Vindo   ")
        {
            modCarro = new ModuloCarro();
            modPecas = new ModuloPecas();
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        private int Opcoes()
        {
            int escolha;
            Console.WriteLine("[1] - Modulo Carro                             |" +
                            "\n[2] - Modulo Peças                             |" +
                            "\n[0] - Sair                                     |");
            Console.WriteLine("************************************************");
            Console.WriteLine("Digite uma Opção:");
            escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }
        private void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    modCarro.Executa();
                    break;
                case 2:
                    modPecas.Executa();
                    break;
                default:
                    break;
            }
        }
    }
    
}
