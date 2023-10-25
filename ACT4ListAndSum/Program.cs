/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 4
 * Implementa un programa que demani a l’usuari quants 
 * valors vol introduir i generi una llista a partir d’aquest
 * valors introduïts per teclat, retornant la suma de tots
 * els elements d’aquesta.
 */
using System;

namespace CSharpArrays
{
    class ActivityFiveTeen
    {
        public static void Main()
        {
            const string SumSymbol = "+";
            const string EqualSymbol = "=";
            const string AskListSize = "Cuantos valores introduciras: ";
            const string AskValue = "Proporcioname el valor {0} de tu lista: ";

            int result=0;
            int[] list;

            Console.Write(AskListSize);
            list = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(AskValue, i+1);
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < list.Length; i++)
            {
                Console.Write(i==0 ? list[i] : SumSymbol + list[i]);
                result += list[i];
            }
            Console.WriteLine(EqualSymbol+result);
        }
    }
}