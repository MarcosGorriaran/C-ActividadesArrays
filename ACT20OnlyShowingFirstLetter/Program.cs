/*
 * Gorriaran Caamaño Marcos Facundo
 * 7/11/2023
 * Exercici 20
 */
using System;

namespace CSharpArrays
{
    class ActivityThirty
    {
        public static void Main()
        {
            const char SplitFirstTarget = ',';
            const string SplitSecondTarget = " i ";
            const string AskText = "Proporcioname a todos los miembros del grupo";

            string fullText;
            string[] splitedText;
            string[] splitedLastPortion;
            string[] allSplited;

            Console.WriteLine(AskText);
            splitedText = Console.ReadLine().Split(SplitFirstTarget);
            splitedLastPortion = splitedText[splitedText.Length - 1].Split(SplitSecondTarget);
            allSplited = new string[splitedText.Length + splitedLastPortion.Length];

            for (int i = 0; i < splitedText.Length; i++)
            {
                Console.Write(splitedText[i].Trim().ToUpper()[0]);
            }
            if(splitedText[splitedText.Length - 1].Split(SplitSecondTarget).Length>1)
            {
                Console.WriteLine(splitedText[splitedText.Length - 1].Split(SplitSecondTarget)[1].Trim().ToUpper()[0]);
            }
            
        }
    }
}