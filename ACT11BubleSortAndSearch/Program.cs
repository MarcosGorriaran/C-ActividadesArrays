/*
 * Gorriaran Caamaño Marcos Facundo
 * 7/11/2023
 * Exercici 11
 * Modifica el programa anterior de manera que mostri les notes 
 * introduïdes ordenades de manera ascendent i descendent 
 * (per separat).
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentytwo
    {
        public static void Main()
        {
            const string AskNote = "Proporcioname la nota {0}: ";
            const string AskSearchTarget = "Proporcioname la nota que deseas buscar: ";
            const string TargetFoundMsg = "El valor se encuentra en la lista";
            const string TargetNotFoundMsg = "El valor no se encuentra en la lista";
            const char WordSpliter = ' ';
            const int AmountNotes = 20;
            const int MinRange = 0;
            const int MaxRange = 10;

            int[] notes = new int[AmountNotes];
            int i;
            int searchTarget;
            int temp;
            bool targetFound = false;

            for (i = 0; i < notes.Length; i++)
            {
                do
                {
                    Console.Write(AskNote, i + 1);
                    notes[i] = Convert.ToInt32(Console.ReadLine());
                } while (notes[i] < MinRange || notes[i] > MaxRange);
            }
            for (i = 0; i<notes.Length-1; i++)
            {
                for(int j = i+1; j < notes.Length; j++)
                {
                    if (notes[i] < notes[j])
                    {
                        temp = notes[i];
                        notes[i] = notes[j];
                        notes[j] = temp;
                    }
                }
            }
            for (i = 0; i<notes.Length; i++)
            {
                Console.Write(notes[i]+WordSpliter);
            }
            Console.WriteLine();

            for (i = 0; i < notes.Length - 1; i++)
            {
                for (int j = i + 1; j < notes.Length; j++)
                {
                    if (notes[i] > notes[j])
                    {
                        temp = notes[i];
                        notes[i] = notes[j];
                        notes[j] = temp;
                    }
                }
            }
            for (i = 0; i < notes.Length; i++)
            {
                Console.Write(notes[i]+WordSpliter);
            }
            Console.WriteLine();

            Console.Write(AskSearchTarget);
            searchTarget = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i < notes.Length && !targetFound)
            {
                targetFound = searchTarget == notes[i];
                i++;
            }
            Console.WriteLine(targetFound ? TargetFoundMsg : TargetNotFoundMsg);
        }
    }
}