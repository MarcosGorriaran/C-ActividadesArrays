/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 15
 * Implementa un programa que emmagatzemi una frase introduïda per teclat 
 * en la variable textOne. Demana un altre text i emmagatzema’l en la 
 * variable textTwo. Afegeix textTwo a textOne i mostra-la per pantalla.
 * És correcte? Què pots observar a les variables textOne i textTwo?
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentyFive
    {
        public static void Main()
        {
            const string AskText = "Proporcioname texto: ";

            string textOne;
            string textTwo;

            Console.Write(AskText);
            textOne = Console.ReadLine();

            Console.Write(AskText);
            textTwo = Console.ReadLine();

            textOne += textTwo;

            Console.Write(textOne);

            /**
             * El programa no tiene problemas haciendolo correr y ahora
             * textOne contiene un string con los input juntos de textOne
             * y textTwo mientras que textTwo mantiene el valor introducido
             * desde el principio.
             */
        }
    }
}