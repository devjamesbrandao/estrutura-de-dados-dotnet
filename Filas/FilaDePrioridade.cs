using System;
using System.Collections.Generic;
using estrutura_de_dados_dotnet.Entidades;
using estrutura_de_dados_dotnet.Utils;

namespace EDC.Filas
{
    public class FilaDePrioridade
    {
        public List<FilaPrioridade> Fila = new List<FilaPrioridade>();

        public void EnqueueFilaPrioridade(int elemento, int prioridade)
        {
            var valor = new FilaPrioridade(elemento, prioridade);

            var adicionado = false;

            for(var i = 0; i < Fila.Count; i++)
            {
                if(valor.Prioridade < Fila[i].Prioridade)
                {
                    Fila.Splice(i, valor);
                    adicionado = true;
                    break;
                }
            }

            if(!adicionado)
            {
                Fila.Add(valor);
            }
        }


        public List<FilaPrioridade> DequeueFilaPrioridade()
        {
            Fila.RemoveAt(0);
            return Fila;
        }

        public void Print()
        {
            for(var i = 0; i < Fila.Count; i++)
            {
                Console.WriteLine(Fila[i].Elemento + " " + Fila[i].Prioridade);
            }
        }
    }
}