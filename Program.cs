using System;
using EDC.Filas;

namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new BatataQuente();

            jogo.JogarBatataQuente(new string[]{"James", "Rebeca"}, 2);

            // Queue Fila = new Queue();

            // Fila.Enqueue("james");
            // Fila.Enqueue(2);
            // Fila.Enqueue(3);

            // Fila.IsEmpty();

            // Fila.Front();

            // Console.WriteLine(Fila.Dequeue());

            // Fila.Front();

            // Fila.Size();

            // Fila.Dequeue();

            // Fila.Size();

        }
    }
}
