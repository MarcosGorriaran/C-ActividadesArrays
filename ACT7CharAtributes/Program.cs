/*
 * Gorriaran Caamaño Marcos Facundo
 * 25/10/2023
 * Exercici 7
 * Implementa un programa que reculli els valors dels
 * següents atributs per a 4 personatges:
 * vida [1-1000]
 * poder[100-500]
 * força [20-50]
 * Caldrà fer les validacions corresponents als 
 * atributs i mostrar les dades introduïdes en format 
 * de taula.
 */
using System;

namespace CSharpArrays
{
    class ActivityEighteen
    {
        public static void Main()
        {
            const int MinHP = 1;
            const int MaxHP = 1000;
            const int MinPower = 100;
            const int MaxPower = 500;
            const int MinStrength = 20;
            const int MaxStrength = 50;
            const int AmountChar = 4;
            const string AskHP = "Proporcioname la vida del personaje {0} [{1} - {2}]: ";
            const string AskPower = "Proporcioname el poder del personaje {0} [{1} - {2}]: ";
            const string AskStrength = "Proporcioname la fuerza del personaje {0} [{1} - {2}]: ";
            const string TableHeader = "Salud | Poder | Fuerza";
            const string WordSpliter = " | ";
            const string ErrorOutsideRange = "El valor no es valido al no estar en el rango valido.";

            bool repeated;
            int[] charHP = new int[AmountChar];
            int[] charPower = new int[AmountChar];
            int[] charStrength = new int[AmountChar];

            for(int i = 0; i < AmountChar; i++)
            {
                repeated = false;
                do
                {
                    if (repeated)
                    {
                        Console.WriteLine(ErrorOutsideRange);
                    }
                    repeated = true;
                    Console.Write(AskHP, i+1,MinHP,MaxHP);
                    charHP[i] = Convert.ToInt32(Console.ReadLine());
                } while (charHP[i] < MinHP || charHP[i] > MaxHP);
                repeated = false;
                do
                {
                    if (repeated)
                    {
                        Console.WriteLine(ErrorOutsideRange);
                    }
                    repeated = true;
                    Console.Write(AskPower, i + 1, MinPower, MaxPower);
                    charPower[i] = Convert.ToInt32(Console.ReadLine());
                } while (charPower[i] < MinPower || charPower[i] > MaxPower);
                repeated = false;
                do
                {
                    if (repeated)
                    {
                        Console.WriteLine(ErrorOutsideRange);
                    }
                    repeated = true;
                    Console.Write(AskStrength, i + 1, MinStrength, MaxStrength);
                    charStrength[i] = Convert.ToInt32(Console.ReadLine());
                } while (charStrength[i] < MinStrength || charStrength[i] > MaxStrength);
            }

            for (int i = 0; i < AmountChar; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(TableHeader);
                }
                Console.WriteLine(charHP[i] + WordSpliter + charPower[i] + WordSpliter + charStrength[i]);
            }
        }
    }
}