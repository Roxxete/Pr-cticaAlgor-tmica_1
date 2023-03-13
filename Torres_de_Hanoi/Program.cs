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
            Pila DESTINO = new Pila();
            Pila AUXILIAR = new Pila();
            Console.WriteLine("Indica el número de discos...");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Has seleccionado " + n + " discos");
            Pila ORIGEN = new Pila(n);

            //Solo tenemos el iterativo
            Hanoi hanoi = new Hanoi();
            int mov = hanoi.iterativo(n, ORIGEN, AUXILIAR, DESTINO);

            Console.WriteLine("Resuelto en " + mov + " movimientos");

            Console.ReadKey();

        }
    }
}