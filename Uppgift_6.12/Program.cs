using System;
namespace Uppgift_6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            RitaTriangel(3);
            RitaTriangel(4);
        }
        static void RitaTriangel(int höjd)
        {
            for (int i = 0; i < höjd; i++) //Rader
            {
                for (int j = 0; j < höjd - 1 - i; j++) //Tomrummet innan raden
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < 2*i + 1; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}