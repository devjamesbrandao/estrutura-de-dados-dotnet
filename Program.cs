using System;
using EDC.Filas;
using EDC.ListaSimplesLigada;
using estrutura_de_dados_dotnet.Conjuntos;
using estrutura_de_dados_dotnet.Dicionarios;
using estrutura_de_dados_dotnet.Hash;
using estrutura_de_dados_dotnet.ListaDuplalLigada;

namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
           TabelaHashe();
        }

        static void TabelaHashe()
        {
            var hash = new TabelaHash();

            hash.Adicionar("A", "Amora");

            hash.Adicionar("B", "Buriti");
        }

        static void Dicio()
        {
            var dicio = new Dicionarios();

            dicio.Set("A", "Abacaxi");

            dicio.Set("B", "Banana");

            dicio.Deletar("A");

            foreach(var i in dicio.Valores())
            {
                Console.WriteLine(i);
            }

        }


        static void ListaDuplalLigada()
        {
            var lista = new DoubleLinkedList();

            lista.Adicionar(1);

            lista.Adicionar(2);

            lista.Adicionar(3);

            lista.RemoverPosicao(2);
        }

        static void Conjuntos()
        {
            var conjuntos = new Conjuntos();

            conjuntos.Adicionar("A");

            conjuntos.Adicionar("B");

            conjuntos.Adicionar("C");

            var conjuntos2 = new Conjuntos();

            conjuntos2.Adicionar("A");

            conjuntos2.Adicionar("B");

            conjuntos2.Adicionar("C");

            foreach(var i in conjuntos.Diferenca(conjuntos2))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(conjuntos.SubConjunto(conjuntos2));
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
