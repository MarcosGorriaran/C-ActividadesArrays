/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 16
 * Implementa un programa que demani a l’usuari que introdueixi un text i 
 * retorni la seva longitud.
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentySix
    {
        public static void Main()
        {
            const string AskText = "Proporcioname un texto: ";

            string userText;

            Console.Write(AskText);
            userText = Console.ReadLine();

            Console.WriteLine(userText.Length);
        }
    }
}