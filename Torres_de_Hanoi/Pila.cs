using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    //Esta clase representa un objeto individual palo junto con los discos que hay en ese palo.
    class Pila
    {
        //Size para representar la cantidad de discos que hay en el palo.
        public int Size { get; set; }
        //Top para representar el disco que est a en la parte superior del palo.
        public int Top { get; set; }
        //Elementos para representar el conjunto de discos que hay en ese palo.
        public List<Disco> Elementos { get; set; } = new List<Disco>();

        //Constructor vacío
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
        }


        //Constructor
        public Pila(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                this.Elementos.Add(disco);
            }
            this.Size = n;
            this.Top = this.Elementos[this.Size - 1].Valor;

        }

        //Permitirá colocar un disco en la pila de discos.
        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Size++;
            this.Top = d.Valor;
        }

        //Permitirá extraer el disco de la parte superior de la pila.
        public Disco pop()
        {
            Disco disco = new Disco();
            disco = this.Elementos[this.Size - 1];
            this.Elementos.Remove(disco);
            this.Size--;
            if (this.Size != 0)
            {
                this.Top = this.Elementos[this.Size - 1].Valor;

            }
            return disco;
        }

        //Para saber si la pila está o no vacía
        public bool isEmpty()
        {
            if (this.Size != 0) return false;
            return true;
        }

    }
}