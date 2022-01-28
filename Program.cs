using System;
using System.Collections.Generic;
using System.Linq;
using EDC.Filas;

namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Splice(1);
        }

        static void BatataQuente()
        {
            var jogo = new BatataQuente();

            jogo.JogarBatataQuente(new string[]{"James", "Rebeca"}, 2);
        }

        static void Splice(int posicao)
        {
            List<string> foo = new List<string>();

            foo.Add("one");
            foo.Add("two");
            foo.Add("three");

            var bar = foo.Take(posicao + 1).ToList();

            if(foo.Count != bar.Count())
            {
                string[] aux = foo.ToArray()[(posicao + 1)..^0];

                bar.Add("Teste");

                foreach(var i in aux)
                {
                    bar.Add(i);
                }

                foreach(var e in bar)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
