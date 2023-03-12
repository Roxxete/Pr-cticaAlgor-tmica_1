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
            return null;
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}
