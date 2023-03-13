using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila Origen, Pila Destino)
        {
            if (Destino.isEmpty())
            {
                Destino.push(Origen.pop());
            }
            else
            {
                if (Origen.Top < Destino.Top && !Origen.isEmpty())
                {
                    Destino.push(Origen.pop());
                }
                else
                {
                    Origen.push(Destino.pop());
                }
            }

        }


        public int iterativo(int n, Pila Origen, Pila Auxiliar, Pila Destino)
        {
            int m = 0;
            Console.WriteLine("Situación inical:");
            Console.Write("Torre ini: ");
            for (int i = 0; i < Origen.Size; i++)
            {
                Console.Write(Origen.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre aux: ");
            for (int i = 0; i < Auxiliar.Size; i++)
            {
                Console.Write(Auxiliar.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre fin: ");
            for (int i = 0; i < Destino.Size; i++)
            {
                Console.Write(Destino.Elementos[i].Valor + " ");
            }
            Console.WriteLine();

            if (n % 2 != 0)
            {
                while (Destino.Size != n)
                {
                    //-----------------INI FIN------------------
                    mover_disco(Origen, Destino);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                        return m;
                    }

                    //-----------------INI AUX------------------
                    mover_disco(Origen, Auxiliar);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                        return m;
                    }

                    //-----------------AUX FIN------------------
                    mover_disco(Auxiliar, Destino);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                       return m;
                    }
                }
            }
            else
            {
                while (Destino.Size != n)
                {
                    //-----------------INI AuX------------------
                    mover_disco(Origen, Auxiliar);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                        return m;
                    }

                    //-----------------INI FIN------------------
                    mover_disco(Origen, Destino);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                        return m;
                    }

                    //-----------------AUX FIN------------------
                    mover_disco(Auxiliar, Destino);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ini: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre aux: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre fin: ");
                    for (int i = 0; i < Destino.Size; i++)
                    {
                        Console.Write(Destino.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    if (Destino.Size == n)
                    {
                    return m;
                    }
                }
            }
            return m;
        }
    }
}