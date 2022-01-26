using System;

namespace EDC.Filas
{
    public class BatataQuente
    {
        public void JogarBatataQuente(string[] nomes, int numero)
        {
            var fila = new Queue();

            for(var i = 0; i < nomes.Length; i++)
            {
                fila.Enqueue(nomes[i]);
            }

            var eliminado = "";

            while(fila.Size() > 1)
            {
                for(var i = 0; i < numero; i++)
                {
                    fila.Enqueue(fila.Dequeue());
                }

                eliminado = fila.Dequeue();

                Console.WriteLine(eliminado + " foi eliminado do jogo");
            }

            Console.WriteLine(fila.Dequeue() + " foi campeão(ã) do jogo !");
        }
    }
}