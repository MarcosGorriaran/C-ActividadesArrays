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
    class ActivityEighteen
    {
        public static void Main()
        {
            const int row = 7;
            const int col = 3;
            const string AskValue = "Dame el valor {0} {1}: ";

            int[,] Ask = new int[row,col];

            for(int i = 0; i < Ask.GetLength(0); i++)
            {
                for(int j = 0; j < Ask.GetLength(1); j++)
            }
        }
    }
}