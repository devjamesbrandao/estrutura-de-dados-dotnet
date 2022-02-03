using System;
using estrutura_de_dados_dotnet.Entidades;

namespace EDC.ListaSimplesLigada
{
    public class LinkedList
    {
        public int Length = 0;

        Node head = null;

        public void Adicionar(int elemento)
        {
            var node = new Node(elemento);

            if(head == null)
            {
                head = node;
            }
            else
            {
                Node elementoAtual = head;

                while(elementoAtual.Next != null)
                {
                    elementoAtual = elementoAtual.Next;
                }

                elementoAtual.Next = node;
            }

            Length++;
        }


        public bool Inserir(int posicao, int elemento)
        {
            if(posicao >= 0 && posicao <= Length)
            {
                var node = new Node(elemento);

                Node elementoAtual = head;

                Node elementoAnterior = null;

                int indice = 0;

                if(posicao == 0)
                {
                    node.Next = elementoAtual;

                    head = node;
                }
                else
                {
                    while(indice++ < posicao)
                    {
                        elementoAnterior = elementoAtual;

                        elementoAtual = elementoAtual.Next;
                    }

                    node.Next = elementoAtual;

                    elementoAnterior.Next = node;
                }

                Length++;

                return true;
            }
            else
            {
                return false;
            }
        }


        public int? RemoverPosicao(int posicao)
        {   
            if(posicao > -1 && posicao < Length)
            {
                var elementoAtual = head;

                Node elementoAnterior = null;

                int indice = 0;

                if(posicao == 0)
                {
                    head = elementoAtual.Next;
                }
                else
                {
                    while(indice++ < posicao)
                    {
                        elementoAnterior = elementoAtual;

                        elementoAtual = elementoAtual.Next;
                    }

                    elementoAnterior.Next = elementoAtual.Next;
                }

                Length--;

                return elementoAtual?.Value;
            }
            else
            {
                return null;
            }
        }


        public int ObterIndice(int elemento)
        {
            var elementoAtual = head;

            int indice = 0;

            while(elementoAtual != null)
            {
                if(elemento == elementoAtual.Value)
                {
                    return indice;
                }

                indice++;

                elementoAtual = elementoAtual.Next;
            }

            return -1;
        }


        public int? Remover(int elemento)
        {
            var indice = this.ObterIndice(elemento);

            return this.RemoverPosicao(indice);
        }


        public bool EhVazio()
        {
            return Length == 0;
        }


        public int TamanhoLista()
        {
            return Length;
        }


        public Node ObterHead()
        {
            return head;
        }


        public override string ToString()
        {
            Node elementoAtual = head;

            var texto = "";

            while(elementoAtual != null)
            {
                texto += elementoAtual.Value + " ";
                elementoAtual = elementoAtual.Next;
            }

            return texto;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

}