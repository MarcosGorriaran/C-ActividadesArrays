/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 14
 * Fent servir la interpolació, implementa un programa en el que es demani 
 * a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu,
 * com a l’exemple:
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentyFour
    {
        public static void Main()
        {
            const int AmountOfFillers = 3;
            const int NamePosition = 0;
            const int SurnamePosition = 1;
            const int AgePosition = 2;
            const string OutputMessege = "L'{0} {1} té {2} anys";
            const string AskValue = "Proporcioname amb la paraula {0}: ";

            string[] fillingWords = new string[AmountOfFillers];

            for(int i = 0; i < AmountOfFillers; i++)
            {
                Console.Write(AskValue,i+1);
                fillingWords[i] = Console.ReadLine();
            }

            Console.WriteLine(OutputMessege, fillingWords[NamePosition], fillingWords[SurnamePosition], fillingWords[AgePosition]);
        }
    }
}