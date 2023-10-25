/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 1
 * Implementa un programa que demani 20 nombres enters per 
 * teclat i retorni els valors separats en dues files:
 * parell i senars.
 */
using System;

namespace CSharpArrays
{
    class ActivityTwelve 
    {
        public static void Main()
        {
            const int AmountValues = 20;
            const int Div = 2;
            const string WordSpliter = " ";
            const string AskValue = "Proporcioname el valor {0}: ";

            int[] evaluateValues = new int[AmountValues];

            for (int i = 0; i < AmountValues; i++)
            {
                Console.Write(AskValue,i+1);
                evaluateValues[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < AmountValues;i++)
            {
                if (evaluateValues[i] % Div == 0)
                {
                    Console.Write(evaluateValues[i] +WordSpliter);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < AmountValues; i++)
            {
                if (evaluateValues[i] % Div != 0)
                {
                    Console.Write(evaluateValues[i] + WordSpliter);
                }
            }
        }
    }
}