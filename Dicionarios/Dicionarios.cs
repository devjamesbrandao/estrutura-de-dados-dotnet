using System.Collections.Generic;
using System.Linq;

namespace estrutura_de_dados_dotnet.Dicionarios
{
    public class Dicionarios
    {
        public IDictionary<string, string> Items = new Dictionary<string, string>();


        public void Set(string chave, string valor)
        {
            Items[chave] = valor;
        }


        public bool Deletar(string chave)
        {
            if(this.Possui(chave))
            {
                Items.Remove(chave);

                return true;   
            }

            return false;
        }


        public bool Possui(string chave)
        {
            return Items.ContainsKey(chave);
        }


        public string Obter(string chave)
        {
            return this.Possui(chave) ? Items[chave] : null;
        }


        public void Limpar()
        {
            Items.Clear();
        }


        public int Tamanho()
        {
            return Items.Keys.Count;
        }


        public IEnumerable<string> Chaves()
        {
            return Items.Keys;
        }


        public string[] Valores()
        {
            var valores = new List<string>();

            var chaves = Items.Keys.ToList();

            for(var  i = 0; i < chaves.Count; i++)
            {
                valores.Add(Items[chaves[i]]);
            }

            return valores.ToArray();
        }


        public IDictionary<string, string> ObterItems()
        {
            return Items;
        }
    }
}