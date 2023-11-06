/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
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

            for (int i = 0; i < allSplited.Length; i++)
            {
                allSplited[i] = i < splitedText.Length ? splitedText[i] : splitedLastPortion[i - splitedText.Length];
                Console.WriteLine(allSplited[i].Trim().ToUpper()[0]);
            }
        }
    }
}