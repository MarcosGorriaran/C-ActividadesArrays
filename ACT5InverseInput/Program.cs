/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 5
 * Implementa un programa que demani  a l’usuari 10 enters
 * per teclat i els mostri en sentit contrari al que s’ha
 * introduït.
 */
using System;

namespace CSharpArrays
{
    class ActivitySixTeen
    {
        public static void Main()
        {
            const int AmountValues = 10;
            const string AskValue = "Proporcioname con el valor {0}: ";
            const string WordSpliter = " ";

            int[] numList = new int[AmountValues];

            for (int i = 0; i < numList.Length; i++)
            {
                Console.Write(AskValue, i+1);
                numList[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = numList.Length-1;i >= 0;i--) 
            {
                Console.Write(numList[i]+WordSpliter);
            }
        }
    }
}