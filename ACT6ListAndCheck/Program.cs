/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 6
 * Implementa un programa que demani  a l’usuari 10 enters
 * per teclat i els mostri en sentit contrari al que s’ha
 * introduït.
 */
using System;

namespace CSharpArrays
{
    class ActivitySevenTeen
    {
        public static void Main()
        {
            const int SmallerThan = 15;
            const int BiggerThan = 30;
            const int maxAttempts = 2;
            const string AskListSize = "Cuantos valores introduciras: ";
            const string AskValue = "Proporcioname el valor natural {0}: ";

            int attempts = 0;
            int[] numList;

            Console.Write(AskListSize);
            numList = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < numList.Length; i++)
            {
                
                do
                {
                    Console.Write(AskValue, i+1);
                    numList[i] = Convert.ToInt32(Console.ReadLine());
                } while (attempts<=maxAttempts && numList[i]<=0);
                if (attempts>maxAttempts)
                {
                    numList[i] = 0;
                }
                
            }
        }
    }
}