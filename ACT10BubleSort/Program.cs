/*
 * Gorriaran Caamaño Marcos Facundo
 * 7/11/2023
 * Exercici 10
 * Implementa un programa en el que s’introdueixin 20 notes per
 * terminal (valors entre el 0 i el 10 inclosos). Un cop 
 * emmagatzemats, cal demanar a l’usuari quin valor vol cercar i 
 * el programa retornarà si aquest valor es troba entre els 
 * introduïts o no
 */
using System;

namespace CSharpArrays
{
    class ActivityTwentyone
    {
        public static void Main()
        {
            const string AskNote = "Proporcioname la nota {0}: ";
            const string AskSearchTarget = "Proporcioname la nota que deseas buscar: ";
            const string TargetFoundMsg = "El valor se encuentra en la lista";
            const string TargetNotFoundMsg = "El valor no se encuentra en la lista";
            const int AmountNotes = 20;
            const int MinRange = 0;
            const int MaxRange = 10;
            
            int[] notes = new int[AmountNotes];
            int i;
            int searchTarget;
            bool targetFound=false;

            for (i = 0; i < notes.Length; i++)
            {
                do
                {
                    Console.Write(AskNote, i + 1);
                    notes[i] = Convert.ToInt32(Console.ReadLine());
                } while (notes[i]<MinRange || notes[i]>MaxRange);
            }

            Console.Write(AskSearchTarget);
            searchTarget = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i < notes.Length && !targetFound)
            {
                targetFound = searchTarget == notes[i];
                i++;
            }
            Console.WriteLine(targetFound ? TargetFoundMsg:TargetNotFoundMsg);
        }
    }
}