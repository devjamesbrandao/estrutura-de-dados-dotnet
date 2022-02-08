using System;
using System.Collections.Generic;

namespace estrutura_de_dados_dotnet.Hash
{
    public class TabelaHash
    {
        public IDictionary<int, string> Tabela = new Dictionary<int, string>();

        public void Adicionar(string chave, string valor)
        {
            var posicao = this.GerarHash(chave);

            Console.WriteLine(posicao + " " + chave);

            Tabela[posicao] = valor;
        }

        public int GerarHash(string chave)
        {
            int hash = 0;

            for(var i = 0; i < chave.Length; i++)
            {
                hash += (int)chave[i];
            }

            return hash % 37;
        }
    }
}