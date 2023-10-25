/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 2
 * Implementa un programa que demani 20 nombres enters per 
 * teclat i retorni els valors de les posicions senars.
 */
using System;

namespace CSharpArrays
{
    class ActivityThirteen
    {
        public static void Main()
        {
            const int AmountValues = 20;
            const int Div = 2;
            const int StartByOdd = 1;
            const string WordSpliter = " ";
            const string AskValue = "Proporcioname el valor {0}: ";

            int[] providedValues = new int[AmountValues];

            for (int i = 0; i < AmountValues; i++)
            {
                Console.Write(AskValue, i + 1);
                providedValues[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = StartByOdd;i < AmountValues; i+=Div)
            {
                Console.Write(providedValues[i]+WordSpliter);
            }
        }
    }
}