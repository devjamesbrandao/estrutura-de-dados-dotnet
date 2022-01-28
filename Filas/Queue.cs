using System;

namespace EDC.Filas
{
    public class Queue
    {
        public string[] Items = new string[10];

        public int Count = 0;

        public void Enqueue(string Element)
        {
            Items[Count] = Element;
            Count ++;
        }

        public string Dequeue()
        {
            if(this.Count == 0)
            {
                Console.WriteLine("A fila está vazia!");
                return "";
            }
            else
            {
                string Returned = Items[0];

                for(int i = 0; i < this.Count - 1; i++){
                    this.Items[i] = this.Items[i+1];
                }

                this.Items[this.Count - 1] = null;

                this.Count--;
                
                return Returned;
            }
        }

        public string Front()
        {
            if(Count == 0)
            {
                return "";
            } 
            else 
            {
                return this.Items[0];
            }
        }

        public bool IsEmpty()
        {
            if(this.Count == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public int Size()
        {
            if(this.Count == 0)
            {
                Console.WriteLine("A Fila não contém elementos");
            }

            return Count;
        }

        public void Show()
        {
            for(int i = 0; i < this.Count; i++){ 
                Console.WriteLine($"Na posição {i} o valor é {Items[i]} \n");
            }
        }

    }
}