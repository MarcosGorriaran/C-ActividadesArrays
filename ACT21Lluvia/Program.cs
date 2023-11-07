/*
 * Gorriaran Caamaño Marcos Facundo
 * 4/11/2023
 * Exercici 21
 * El següent tipus de dades emmagatzema les quantitats mitjanes de 
 * pluja per cada mes de l’any:
 * Implementa un programa perquè faci el següent:
 */
using System;

namespace CSharpArrays
{
    class ActivityThirtione
    {
        public static void Main()
        {
            const float MinRange = 5.0f;
            const float MaxRange = 18.0f;
            const string MonthText = "Mes {0}: ";
            const string AvarageOutput = "La mediana es {0}";
            const string InRangeAmount = "Hay {0} meses con medianas de lluvias entre {1} y {2} litros";
            const string AskSearchTarget = "¿Que valor deseas que busque?: ";
            const string TargetFoundMsg = "El valor se encuentra en la lista";
            const string TargetNotFoundMsg = "El valor no se encuentra en la lista";

            float[] arrayPluges = {15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f};
            float temp;
            float rainSum = 0;
            float searchTarget;
            int inRangeCount=0;
            int i;
            bool targetFound = false;
            

            for(i = 0; i < arrayPluges.Length-1; i++)
            {
                for(int j = i + 1; j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[j] > arrayPluges[i])
                    {
                        temp = arrayPluges[j];
                        arrayPluges[j] = arrayPluges[i];
                        arrayPluges[i] = temp;
                    }
                }
                
            }
            
            for (i = 0;i < arrayPluges.Length;i++)
            {
                Console.WriteLine(MonthText + arrayPluges[i], i);
                rainSum += arrayPluges[i];
                if (arrayPluges[i]>=MinRange && arrayPluges[i]<=MaxRange) 
                {
                    inRangeCount++;
                }
            }
            Console.WriteLine(AvarageOutput,rainSum/arrayPluges.Length);
            Console.WriteLine(InRangeAmount,inRangeCount,MinRange,MaxRange);
            Console.Write(AskSearchTarget);
            searchTarget = Convert.ToSingle(Console.ReadLine());

            i = 0;
            while (i<arrayPluges.Length && !targetFound)
            {
                targetFound = arrayPluges[i] == searchTarget;
                i++;
            }
            Console.WriteLine(targetFound ? TargetFoundMsg : TargetNotFoundMsg);
        }
    }
}