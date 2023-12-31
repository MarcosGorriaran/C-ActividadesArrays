﻿/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 3
 * Especifica un algorisme que demani 20 nombres enters 
 * (compresos entre 1 i 9 inclosos) per teclat. Cal que 
 * l’algorisme imprimeixi els valors de dreta a esquerra 
 * i després d’esquerra a dreta.
 */
using System;

namespace CSharpArrays
{
    class ActivityFourTeen
    {
        public static void Main()
        {
            const int AmountValues = 20;
            const int RangeMin = 1;
            const int RangeMax = 9;
            const string WordSpliter = " ";
            const string AskValue = "Proporcioname el valor {0}: ";
            const string ErrorOutsideOfAllowedRange = "El valor proporcionado esta fuera del rango permitido [{0} - {1}]";

            int[] providedValues = new int[AmountValues];

            for (int i = 0; i < AmountValues; i++)
            {
                bool repeated = false;
                do
                {
                    if (repeated)
                    {
                        Console.WriteLine(ErrorOutsideOfAllowedRange,RangeMin,RangeMax);
                    }
                    repeated = true;
                    Console.Write(AskValue, i + 1);
                    providedValues[i] = Convert.ToInt32(Console.ReadLine());
                } while (providedValues[i]<RangeMin || providedValues[i]>RangeMax);
                
            }

            for (int i = 0; i < AmountValues; i++)
            {
                Console.Write(providedValues[i]+WordSpliter);
            }
            Console.WriteLine();
            for (int i = AmountValues-1; i >= 0; i--)
            {
                Console.Write(providedValues[i]+WordSpliter);
            } 
        }
    }
}