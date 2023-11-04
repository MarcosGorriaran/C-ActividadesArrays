/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 18
 * Fent servir la interpolació i l’operador ternari, implementa un programa
 * que indiqui pels 20 primers nombres (del 1 al 20 inclosos) si és parell
 * o senar (només ha d’indicar per a cada valor “És parell”/”És senar)”.
 */

using System;

namespace CSharpArrays
{
    class ActivityTwentyEight
    {
        public static void Main()
        {
            const int MinValue = 1;
            const int MaxValue = 20;
            const int Div = 2;
            const int EvenResult = 0;
            const string IsEvenOdd = "{0}: {1}";
            const string Even = "Es par";
            const string Odd = "Es impar";

            for (int i = MinValue; i <= MaxValue; i++)
            {
                Console.WriteLine(IsEvenOdd,i,i%Div==EvenResult ? Even : Odd);
            }
        }
    }
}