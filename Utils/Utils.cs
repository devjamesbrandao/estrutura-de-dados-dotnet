using System;
using System.Collections.Generic;
using System.Linq;
using estrutura_de_dados_dotnet.Entidades;

namespace estrutura_de_dados_dotnet.Utils
{
    public static class Utils
    {
        public static void Add(this List<FilaPrioridade> vetor, int elemento, int prioridade)
        {
            int contador = 0;

            foreach(var i in vetor)
            {
                if(i != null)
                {
                    contador++;
                }
            }

            if(contador == 0)
            {
                throw new Exception("Vetor cheio!");
            }

            vetor[(contador)].Elemento = elemento;

            vetor[(contador)].Prioridade = prioridade;
        }

        public static void Splice(
            this List<FilaPrioridade> fila, int posicao, 
            FilaPrioridade elemento
        )
        {
            var primeirosElementos = fila.Take(posicao).ToList();

            var elementosFinais = fila
                .ToArray()[(posicao)..^0];

            primeirosElementos.Add(elemento);

            fila.Clear();

            foreach(var i in primeirosElementos)
            {
                fila.Add(i);
            }

            foreach(var x in elementosFinais)
            {
                fila.Add(x);
            }
        }
    }
}