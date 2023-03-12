using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila Origen, Pila Destino)
        {
            Disco disco = new Disco();
            Disco d;
            disco = Origen.pop();
            if(Destino.Top > disco.Valor)
            {
                Destino.push(disco);
            }
            else
            {
                d = Destino.pop();
                Origen.push(d); 
            }
            if (Origen.isEmpty())
            {
                Destino.pop(d);
                Origen.push(d);
            }
            
        }

        public int iterativo(int n, Pila Origen, Pila Destino, Pila Aux)
        {
           
            return 0;
        }

    }
}
