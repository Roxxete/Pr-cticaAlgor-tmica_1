using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        
        public int Top { get; set; }
        
        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */

        public Pila(int n)
        {
            this.Size = n;
        }
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;

        }

        public void push(Disco d)
        {
            this.Size++;
            this.Top = d.Valor;
            this.Elementos.Add(d);
        }

        public Disco pop()
        {
            this.Size--;
            Disco primero = this.Elementos[this.Elementos.Count - 1];
            this.Elementos.Remove(primero);
            this.Top = this.Elementos[this.Elementos.Count - 1].Valor;
            return primero;
        }                

        public bool isEmpty()
        {
            if (this.Size == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
