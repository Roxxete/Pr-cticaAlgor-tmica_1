using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("Indica el número de discos...");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Has seleccionado " + n + " discos");
            //Inicializar pilas.
            Pila ORIGEN = new Pila(n);
            Pila DESTINO = new Pila();
            Pila AUXILIAR = new Pila();

            //Solo tenemos el iterativo
            Hanoi hanoi = new Hanoi();
            //Devuelve número de movimientos.
            int mov = hanoi.iterativo(n, ORIGEN, AUXILIAR, DESTINO);

            Console.WriteLine("Resuelto en " + mov + " movimientos");

            Console.ReadKey();

        }
    }
}