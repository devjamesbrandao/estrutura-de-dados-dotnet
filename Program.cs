using System;
using EDC.Filas;
using EDC.ListaSimplesLigada;

namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void ListaLigada()
        {
            var lista = new LinkedList();

            lista.Adicionar(1);

            lista.Inserir(1, 2);

            lista.Adicionar(3);

            lista.Remover(2);

            Console.WriteLine(lista.ToString());

            Console.WriteLine($"{lista.ObterHead().ToString()}, {lista.TamanhoLista()}");
        }

        static void FilaPrioridade()
        {
            var filaBanco = new FilaDePrioridade();

            filaBanco.EnqueueFilaPrioridade(1, 3);

            filaBanco.EnqueueFilaPrioridade(2, 2);

            filaBanco.EnqueueFilaPrioridade(7, 2);

            filaBanco.EnqueueFilaPrioridade(10, 1);

            filaBanco.DequeueFilaPrioridade();

            filaBanco.Print();
        }

        static void BatataQuente()
        {
            var jogo = new BatataQuente();

            jogo.JogarBatataQuente(new string[]{"James", "Rebeca"}, 2);
        }
    }
}
