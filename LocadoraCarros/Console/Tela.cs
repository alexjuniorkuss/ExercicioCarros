using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public delegate int Opcoes();
    public delegate void Escolha(int escolha);
    public class Tela
    {
        // crio a tela ja com um parametro de _nome vazio private po usar somente dentro da classe
        private string _nomeTela = "";
        //estancio as funcoes para opcoes e escolhas como protected pois só vao ser usadas em quem 
        //herdar da classe tela
        protected Opcoes funcaoOpcoes;
        protected Escolha funcaoEscolha;
        //construtor executa antes de criar os metodos
        public Tela(string nomeTela)
        {
            this._nomeTela = nomeTela; 
        }
        public void Cabecalho()
        {
            Console.WriteLine( "************************************************");
            Console.WriteLine($"****************{this._nomeTela}****************");
            Console.WriteLine("************************************************");
        }
        public void Executa()
        {
            int escolha = 0;
            do
            {
                Console.Clear();
                // limpou a tela e exibiu o cabecalho
                Cabecalho();
                //joga a escolha do usuario entro de escolha
                escolha = funcaoOpcoes();
                //funcao esoclha recebe o que foi recebido em escolha e vai fazer o direcionamentos
                funcaoEscolha(escolha);
            } while (escolha != 0);
        }
    }
}
