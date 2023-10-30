/*
 * Gorriaran Caamaño Marcos Facundo
 * 30/10/2023
 * Exercici 6
 * Implementa un programa que demani a l’usuari quants valors 
 * vol emmagatzemar (en una llista). A continuació l’usuari els 
 * haurà d’introduir i el programa haurà de validar si és un 
 * nombre natural o no. En cas que no ho sigui, informarà a 
 * l’usuari i aquest disposarà de dos intents més per a 
 * introduir el nombre correctament. Aquesta restricció és per 
 * a tots els nombres que l’usuari introdueixi. En finalitzar, 
 * el programa haurà de retornar:
 * Total de nombres introduïts
 * Total de nombres més petits de 15
 * Total de nombres més grans de 30
 */
using System;

namespace CSharpArrays
{
    class ActivitySevenTeen
    {
        public static void Main()
        {
            const int SmallerThan = 15;
            const int BiggerThan = 30;
            const int MaxAttempts = 3;
            const string ErrorNotNatural = "El valor introducido no es natural";
            const string AskListSize = "Cuantos valores introduciras: ";
            const string AskValue = "Proporcioname el valor natural {0}: ";
            const string AmountValues = "Se han introducido {0} valores.";
            const string AmountBigValues = "Se han introducido {0} valores mas grandes de {1}.";
            const string AmountSmallValues = "Se han introducido {0} valores mas pequeños de {1}.";

            bool repeated;
            int attempts;
            int[] numList;
            int insertedValues = 0;
            int biggerValues = 0;
            int smallerValues = 0;

            Console.Write(AskListSize);
            numList = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < numList.Length; i++)
            {
                attempts = 0;
                repeated = false;
                do
                {
                    if (repeated)
                    {
                        attempts++;
                        Console.WriteLine(ErrorNotNatural);
                    }
                    repeated= true;
                    if (attempts < MaxAttempts)
                    {
                        Console.Write(AskValue, i + 1);
                        numList[i] = Convert.ToInt32(Console.ReadLine());
                    }
                } while (attempts<MaxAttempts && numList[i]<=0);
                if (attempts>=MaxAttempts)
                {
                    numList[i] = 0;
                }
                else
                {
                    insertedValues++;
                    if (numList[i] > BiggerThan)
                    {
                        biggerValues++;
                    }
                    if (numList[i] < SmallerThan)
                    {
                        smallerValues++;
                    }
                }
            }
            Console.WriteLine(AmountValues,insertedValues);
            Console.WriteLine(AmountBigValues,biggerValues, BiggerThan);
            Console.WriteLine(AmountSmallValues,smallerValues, SmallerThan);
        }
    }
}