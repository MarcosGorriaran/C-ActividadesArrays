/*
 * Gorriaran Caamaño Marcos Facundo
 * 04/11/2023
 * Exercici 13
 * Implementa un programa en el que s’introdueixin 20 notes per terminal 
 * (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a 
 * l’usuari si vol mostrar els valors ordenats de manera ascendent o 
 * descendent i mostrar-ho per pantalla.
 */

using System;

namespace CSharpArrays
{
    class ActivityTwentyThree
    {
        public static void Main()
        {
            const int MinNote = 0;
            const int MaxNote = 10;
            const int AmountNotes = 20;
            const char AscChar = 'A';
            const char DescChar = 'D';
            const string AskNote = "Proporcioname la nota {0}: ";
            const string AskAscOrDesc = "Quieres que lo ordene descendentemente o ascendentemente [{0}/{1}]: ";
            const string WordSpliter = " ";

            int[] notes = new int[AmountNotes];
            int temp;
            char answer;

            for(int i = 0; i < AmountNotes; i++)
            {
                do
                {                
                    Console.WriteLine(AskNote,i+1);
                    notes[i] = Convert.ToInt32(Console.ReadLine());
                }while (notes[i]<MinNote || notes[i]>MaxNote);
            }
            do
            {
                Console.WriteLine(AskAscOrDesc,AscChar,DescChar);
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer != AscChar && answer != DescChar);

            if(answer == AscChar)
            {
                for (int i = 0; i < AmountNotes - 1; i++)
                {
                    for (int j = i + 1; j < AmountNotes; j++)
                    {
                        if (notes[j] < notes[i])
                        {
                            temp = notes[j];
                            notes[j] = notes[i];
                            notes[i] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < AmountNotes - 1; i++)
                {
                    for (int j = i + 1; j < AmountNotes; j++)
                    {
                        if (notes[j] > notes[i])
                        {
                            temp = notes[j];
                            notes[j] = notes[i];
                            notes[i] = temp;
                        }
                    }
                }
            }
            for (int i = 0;i < AmountNotes; i++)
            {
                Console.Write(notes[i]+WordSpliter);
            }
        }
    }
}