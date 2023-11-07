/*
 * Gorriaran Caamaño Marcos Facundo
 * 30/10/2023
 * Exercici 9
 * Especifica un algorisme que demani a l’usuari que 
 * introdueixi els números d’una matriu de 7 files 
 * per 3 columnes (compresos entre 1 i 9 inclosos) 
 * per teclat. Una vegada la matriu estigui omplerta,
 * cal que el vostre programa mostri la matriu
 * trasposta (només els valors, sense els claudàtors).
 */
using System;

namespace CSharpArrays
{
    class ActivityTwenty
    {
        public static void Main()
        {
            const int MinRange = 1;
            const int MaxRange = 9;
            const int Row = 7;
            const int Col = 3;
            const string AskValue = "Dame el valor {0} {1}: ";

            int[,] ask = new int[Row,Col];

            for (int i = 0; i < ask.GetLength(0); i++)
            {
                for (int j = 0; j < ask.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write(AskValue, i + 1, j + 1);
                        ask[i, j] = Convert.ToInt32(Console.ReadLine());
                    } while (ask[i, j]<MinRange || ask[i, j]>MaxRange);
                    
                }
            }

            for (int i = 0; i < ask.GetLength(0); i++)
            {
                for(int j = 0; j < ask.GetLength(1); j++)
                {
                    Console.Write(ask[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i = 0;i < ask.GetLength(1); i++)
            {
                for (int j = 0;j < ask.GetLength(0); j++)
                {
                    Console.Write(ask[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}