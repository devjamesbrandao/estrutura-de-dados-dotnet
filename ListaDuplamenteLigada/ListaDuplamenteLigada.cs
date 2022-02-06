using System;
using estrutura_de_dados_dotnet.Entidades;

namespace estrutura_de_dados_dotnet.ListaDuplalLigada
{
    public class DoubleLinkedList
    {
        public int tamanho = 0;

        public Node2 cabeca = null;

        public Node2 cauda = null;

        public void Adicionar(int elemento)
        {
            Node2 node = new Node2(elemento);

            Node2 elementoAtual = null;

            if(cabeca == null)
            {
                cabeca = node;

                cauda = node;
            }
            else
            {
                elementoAtual = cabeca;

                while(elementoAtual.Proximo != null)
                {
                    elementoAtual = elementoAtual.Proximo;
                }

                elementoAtual.Proximo = node;

                node.Anterior = elementoAtual;

                node.Proximo = null;

                cauda = node;
            }

            tamanho++;
        }


        public bool Inserir(int posicao, int elemento)
        {
            if(posicao >= 0 && posicao <= tamanho)
            {
                var node = new Node2(elemento);

                Node2 elementoAtual = cabeca;

                Node2 elementoAnterior = null;

                int indice = 0;

                if(posicao == 0)
                {
                    if(!(cabeca != null))
                    {
                        cabeca = node;

                        cauda = node;
                    }
                    else
                    {
                        node.Proximo = elementoAtual;

                        elementoAtual.Anterior = node;

                        cabeca = node;
                    }
                }
                else if(posicao == tamanho)
                {
                    elementoAtual = cauda;

                    elementoAtual.Proximo = node;

                    node.Anterior = elementoAtual;

                    cauda = node;
                }
                else
                {
                    while(indice++ < posicao)
                    {
                        elementoAnterior = elementoAtual;

                        elementoAtual = elementoAtual.Proximo;
                    }

                    node.Proximo = elementoAtual;

                    elementoAnterior.Proximo = node;

                    elementoAtual.Anterior = node;

                    node.Anterior = elementoAnterior;
                }

                tamanho++;

                return true;
            }
            else
            {
                return false;
            }
        }


        public int? RemoverPosicao(int posicao)
        {
            if(posicao > -1 && posicao < tamanho)
            {
                Node2 elementoAtual = cabeca;

                Node2 elementoAnterior = null;

                int indice = 0;

                if(posicao == 0)
                {
                    cabeca = elementoAtual.Proximo;

                    if(tamanho == 1)
                    {
                        cauda = null;
                    }
                    else
                    {
                        cabeca.Anterior = null;
                    }
                }
                else if(posicao == tamanho - 1)
                {
                    elementoAtual = cauda;

                    cauda = elementoAtual.Anterior;

                    cauda.Proximo = null;
                }
                else
                {
                    while(indice++ < posicao)
                    {
                        elementoAnterior = elementoAtual;

                        elementoAtual = elementoAtual.Proximo;
                    }

                    elementoAnterior.Proximo = elementoAtual.Proximo;

                    elementoAtual.Proximo.Anterior = elementoAnterior;
                }

                tamanho--;

                return elementoAtual.Elemento;
            }
            else
            {
                return null;
            }
        }


        public int? Remover(int elemento)
        {
            var indice = this.ObterIndice(elemento);

            return this.RemoverPosicao(indice);
        }


        public int ObterIndice(int elemento)
        {
            var elementoAtual = cabeca;

            int indice = 0;

            while(elementoAtual != null)
            {
                if(elemento == elementoAtual.Elemento)
                {
                    return indice;
                }

                indice++;

                elementoAtual = elementoAtual.Proximo;
            }

            return -1;
        }


        public bool EhVazio()
        {
            return tamanho == 0;
        }

        public int ObterTamanho()
        {
            return tamanho;
        }

        public Node2 ObterCabeca()
        {
            return cabeca;
        }

        public override string ToString()
        {
            var elementoAtual = cabeca;

            var texto = "";

            while(elementoAtual != null)
            {
                texto += elementoAtual.Elemento + " ";
                elementoAtual = elementoAtual.Proximo;
            }

            return texto;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}