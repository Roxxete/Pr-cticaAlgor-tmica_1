using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        const int MAX_DISCOS = 10;
        class Monton  //Un palito
        {
            public int[] Discos = new int[MAX_DISCOS];
            public int NumDiscos = 0; //Inicias palito con 0 discos
        }

        class Hanoii
        {
            public Monton[] Pilas = new Monton[3];
            public int NumDiscos;
        }

        static void HanoiInit(Hanoii H, int num)
        {
            H.NumDiscos = num;
            for (int i = 0; i < 3; i++) H.Pilas[i] = new Monton();
            for (int i = num; i > 0; i--) H.Pilas[0].Discos[H.Pilas[0].NumDiscos++] = i;

        }

        static void HanoiMoverDisco(Hanoii H, int Origen, int Destino)
        {
            int disco = H.Pilas[Origen].Discos[--H.Pilas[Origen].NumDiscos];
            H.Pilas[Destino].Discos[H.Pilas[Destino].NumDiscos++] = disco;
            HanoiDraw(H);

        }

        static int CalcularAux(int Origen, int Destino)
        {
            if (Origen == 0 && Destino == 1) return 2;
            if (Origen == 0 && Destino == 2) return 1;
            if (Origen == 1 && Destino == 2) return 0;
            if (Origen == 1 && Destino == 0) return 2;
            if (Origen == 2 && Destino == 0) return 1;
            if (Origen == 2 && Destino == 1) return 0;
            return -1;
        }

        static void HanoiMoverDiscos(Hanoii H, int Origen, int Destino, int num)
        {
            int aux = CalcularAux(Origen, Destino);
            if (num > 1) HanoiMoverDiscos(H, Origen, aux, num - 1);
            HanoiMoverDisco(H, Origen, Destino);
            if (num > 1) HanoiMoverDiscos(H, aux, Destino, num - 1);
        }

        static void HanoiMover(Hanoii H, int Destino)
        {
            HanoiMoverDiscos(H, 0, Destino, H.NumDiscos);
        }




        static void HanoiDraw(Hanoii H)
        {
            Console.WriteLine("====================================================");
            for (int p = 0; p < 3; p++)
            {
                Console.Write(p + ": ");
                for (int i = 0; i < H.Pilas[p].NumDiscos; i++) Console.Write(H.Pilas[p].Discos[i] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Hanoii H = new Hanoii(); //Una variable que tiene 3 pilas/montones y cada montón tiene un vector en el que caben un máximo de discos.
            HanoiInit(H, 5);
            HanoiDraw(H);
            HanoiMover(H, 2);
            Console.WriteLine("Ya está");
            Console.ReadKey();
        }
    }
}

