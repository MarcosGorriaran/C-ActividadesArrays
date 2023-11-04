/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 19
 * Fent servir la interpolació, implementa un programa que mostri el
 * contingut del jagged array
 */

using System;

namespace CSharpArrays
{
    class ActivityTwentyEight
    {
        public static void Main()
        {
            const string RowWord = "\nFila: ";
            const string WordSpliter = " ";

            int[][] jaggedArr = {
                new int[] { 1, 2, 3, 4 },
                new int[] { 11, 34, 67 },
                new int[] { 89, 23 },
                new int[] { 0, 45, 78, 53, 99 }
            };
            


            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write(RowWord);
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j]+WordSpliter);
                }
            }
        }
    }
}
