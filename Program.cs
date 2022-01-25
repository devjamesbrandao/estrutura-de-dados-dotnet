using System;
using EDC.Filas;

namespace EDC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Fila = new Queue();

            Fila.Enqueue(1);
            Fila.Enqueue(2);
            Fila.Enqueue(3);

            Fila.IsEmpty();

            Fila.Front();

            Console.WriteLine(Fila.Dequeue());

            Fila.Show();

            // Fila.Size();

            // Fila.Dequeue();

            // Fila.Size();

        }
    }
}
