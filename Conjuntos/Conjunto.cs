using System.Collections.Generic;
using System.Linq;

namespace estrutura_de_dados_dotnet.Conjuntos
{
    public class Conjuntos
    {
        public IDictionary<string, string> Items = new Dictionary<string, string>();

        
        public bool Adicionar(string elemento)
        {
            if(!this.Possui(elemento))
            {
                Items[elemento] = elemento;
            }

            return false;
        }


        public bool Deletar(string elemento)
        {
            if(this.Possui(elemento))
            {
                Items.Remove(elemento);

                return true;
            }

            return false;
        }


        public bool Possui(string elemento)
        {
            return Items.ContainsKey(elemento);
        }

        public void Esvaziar()
        {
            Items.Clear();
        }

        public int Tamanho()
        {
            return Items.Keys.Count;
        }

        public List<string> Valores()
        {
            List<string> valores = new List<string>();

            var keys = (Items.Keys).ToList();

            for(var i = 0; i < keys.Count; i++)
            {
                valores.Add(Items[keys[i]]);
            }

            return valores;
        }


        public IEnumerable<string> Unir(Conjuntos Outro)
        {
            var set = new HashSet<string>(this.Valores());

            foreach(var i in Outro.Valores())
            {
                set.Add(i);
            }

            return set;
        }


        public IEnumerable<string> Interseccao(Conjuntos Outro)
        {
            var intersec = new HashSet<string>();

            var valores = this.Valores();

            for(var i = 0; i < valores.Count; i++)
            {
                if(Outro.Possui(valores[i]))
                {
                    intersec.Add(valores[i]);
                }
            }

            return intersec;
        }


        public IEnumerable<string> Diferenca(Conjuntos outro)
        {
            var diferenca = new HashSet<string>();

            var valores = this.Valores();

            for(var i = 0; i < valores.Count; i++)
            {
                if(!outro.Possui(valores[i]))
                {
                    diferenca.Add(valores[i]);
                }
            }

            return diferenca;
        }


        public bool SubConjunto(Conjuntos outro)
        {
            if(this.Tamanho() > outro.Tamanho())
            {
                return false;
            }
            else
            {
                var valores = this.Valores();

                for(var i = 0; i < valores.Count; i++)
                {
                    if(!outro.Possui(valores[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}