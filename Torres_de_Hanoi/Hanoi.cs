﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    //Esta clase representa la lógica de los movimientos y la resolución del problema
    class Hanoi
    {
        //Nos permite mover un disco entre dos palos
        public void mover_disco(Pila Origen, Pila Destino)
        {
            //Representa el movimiento entre Pilas
            if (Destino.isEmpty())
            {
                Destino.push(Origen.pop());
            }
            else
            {
                //NORMA:
                //Si el disco TOP del palo origen es menor que el disco TOP del palo Destino, se mueve de Origen a Destino.
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
            Console.WriteLine("Situación inicial:");
            Console.Write("Torre ORÍGEN: ");
            for (int i = 0; i < Origen.Size; i++)
            {
                Console.Write(Origen.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre AUXILIAR: ");
            for (int i = 0; i < Auxiliar.Size; i++)
            {
                Console.Write(Auxiliar.Elementos[i].Valor + " ");
            }
            Console.WriteLine();
            Console.Write("Torre DESTINO: ");
            for (int i = 0; i < Destino.Size; i++)
            {
                Console.Write(Destino.Elementos[i].Valor + " ");
            }
            Console.WriteLine();

            //Si el número no es par
            if (n % 2 != 0)
            {
                while (Destino.Size != n)
                {
                    //-----------------INI FIN------------------
                    mover_disco(Origen, Destino);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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
                    //-----------------INI AUX------------------
                    mover_disco(Origen, Auxiliar);
                    m++;
                    Console.WriteLine("Situación tras el movimiento: " + m);
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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
                    Console.Write("Torre ORÍGEN: ");
                    for (int i = 0; i < Origen.Size; i++)
                    {
                        Console.Write(Origen.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre AUXILIAR: ");
                    for (int i = 0; i < Auxiliar.Size; i++)
                    {
                        Console.Write(Auxiliar.Elementos[i].Valor + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Torre DESTINO: ");
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