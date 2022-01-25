using System;
using System.Collections.Generic;

namespace EDC.Filas
{
    public class Queue
    {
        public int[] Items = new int[10];

        public int Count = 0;

        public void Enqueue(int Element)
        {
            Items[Count] = Element;
            Count ++;
        }

        public int Dequeue()
        {
            if(this.Count == 0)
            {
                Console.WriteLine("A fila está vazia!");
                return -1;
            }
            else
            {
                int Returned = Items[0];

                for(int i = 0; i < this.Count - 1; i++){
                    this.Items[i] = this.Items[i+1];
                }

                this.Items[this.Count - 1] = 0;

                this.Count--;
                
                return Returned;
            }
        }

        public void Front()
        {
            if(Count == 0)
            {
                Console.WriteLine("Não existe elementos na Fila!");
            } 
            else 
            {
                Console.WriteLine(this.Items[0]);
            }
        }

        public void IsEmpty()
        {
            if(this.Count == 0)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
        }

        public void Size()
        {
            if(this.Count == 0)
            {
                Console.WriteLine("A Fila não contém elementos");
            } 
            else 
            {
                Console.WriteLine("O tamanho da Fila é: " + this.Count);
            }
        }

        public void Show()
        {
            for(int i = 0; i < this.Count; i++){ 
                Console.WriteLine($"Na posição {i} o valor é {Items[i]} \n");
            }
        }

    }
}