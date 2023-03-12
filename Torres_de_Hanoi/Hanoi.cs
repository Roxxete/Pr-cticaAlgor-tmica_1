using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
            disco = Origen.pop();
            Disco d;
            

            if (Destino.isEmpty())
            {
                Destino.push(disco);
            }
            if (Destino.Top > disco.Valor)
            {
                Destino.push(disco);
            }
            else
            {
                d = Destino.pop();
                Origen.push(d); 
            }
            
            
        }

        public int iterativo(int n, Pila Origen, Pila Destino, Pila Aux)
        {
            int cont = 0;
            Console.WriteLine("INICIO");
            Console.Write("Torre ORÍGEN: ");
            for(int i = 0; i < Origen.Size; i++)
            {
                Console.Write(Origen.Elementos[i].Valor);
            }
            Console.Write("Torre AUXILIAR: ");
            for (int i = 0; i < Aux.Size; i++)
            {
                Console.Write(Aux.Elementos[i].Valor);
            }
                Console.Write("Torre DESTINO: ");
            for (int i = 0; i < Destino.Size; i++)
            {
                Console.Write(Destino.Elementos[i].Valor);
            }
            Console.WriteLine();

            if( n%2 != 0)
            {
                 while (Aux.Size != n)
                    {
                        mover_disco(Origen, Destino);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                        mover_disco(Origen, Aux);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                        mover_disco(Aux, Destino);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                    }
            }

            if (n % 2 == 0)
            {
               while (Aux.Size != n)
                    {
                        mover_disco(Origen, Aux);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                        mover_disco(Origen, Destino);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                        mover_disco(Aux, Destino);
                        cont++;
                        Console.WriteLine("Situación tras movimiento" + cont);
                        Console.Write("Torre ORÍGEN: ");
                        for (int i = 0; i < Origen.Size; i++)
                        {
                            Console.Write(Origen.Elementos[i].Valor);
                        }
                        Console.Write("Torre AUXILIAR: ");
                        for (int i = 0; i < Aux.Size; i++)
                        {
                            Console.Write(Aux.Elementos[i].Valor);
                        }
                        Console.Write("Torre DESTINO: ");
                        for (int i = 0; i < Destino.Size; i++)
                        {
                            Console.Write(Destino.Elementos[i].Valor);
                        }
                        Console.WriteLine();
                    }

            }
            return cont;
        }

            
    }

}
