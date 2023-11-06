/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 17
 * Implementa un programa que demani a l’usuari que introdueixi un text i 
 * el retorni tot en majúscules, tot en minúscules i la primera lletra de 
 * cada paraula en majúscules (per separat).
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentySeven
    {
        public static void Main()
        {
            const string AskText = "Proporcioname un texto: ";
            const char SpaceSearchTarget = ' ';

            string userText;
            char[] userTextChar;

            Console.Write(AskText);
            userText = Console.ReadLine();

            Console.WriteLine(userText.ToUpper());
            Console.WriteLine(userText.ToLower());
            userTextChar = userText.ToCharArray();
            for(int i = 1; i < userTextChar.Length-1; i++)
            {
                if (userTextChar[i].Equals(SpaceSearchTarget))
                {
                     userTextChar[i+1] = Convert.ToChar(Convert.ToString(userTextChar[i+1]).ToUpper());
                }
                userText = i == 0 ? Convert.ToString(userTextChar[0]).ToUpper() : userText + userTextChar[i];
            }
            userText += userTextChar[userTextChar.Length - 1];
            Console.WriteLine(userText);
        }
    }
}