/*
 * Gorriaran Caamaño Marcos Facundo
 * 30/10/2023
 * Exercici 8
 * Implementa un programa que reculli les següents dades per 10 persones:
 * edat (enter)
 * sexe (H/D, caràcter)
 * salari (decimal)
 * becari (cert/fals, booleà)
 * Un cop recollits tots els valors, cal mostrar-los per pantalla en forma de taula.
 */
using System;

namespace CSharpArrays
{
    class ActivityNineTeen
    {
        public static void Main()
        {
            const int AmountPeople = 10;
            const int MinAge = 0;
            const double MinSalary = 0;
            const char MaleChar = 'H';
            const char FemaleChar = 'D';
            const char YesAnswer = 'Y';
            const char NoAnswer = 'N';
            const string AskAge = "Proporcioname la edad de la persona {0}: ";
            const string AskSex = "Cual es el sexo de la persona {0} ({1}/{2}): ";
            const string AskSalary = "Cual es el salario de la persona {0}: ";
            const string AskIsIntern = "Es la persona {0} un becario? ({1}/{2}): ";
            const string WordSpliter = " | ";
            const string TableHeader = "Edad | Sexo | Salario | becario";

            char yesOrNo;
            int[] age = new int[AmountPeople];
            char[] sex = new char[AmountPeople];
            double[] salary = new double[AmountPeople];
            bool[] isIntern = new bool[AmountPeople];

            for(int i = 0; i < AmountPeople; i++)
            {
                do
                {
                    Console.Write(AskAge,i+1);
                    age[i] = Convert.ToInt32(Console.ReadLine());
                } while (age[i]<MinAge);
                do
                {
                    Console.Write(AskSex, i + 1, MaleChar,FemaleChar);
                    sex[i] = Convert.ToChar(Console.ReadLine());
                } while (sex[i]!=MaleChar && sex[i]!=FemaleChar);
                do
                {
                    Console.Write(AskSalary, i + 1);
                    salary[i] = Convert.ToDouble(Console.ReadLine());
                } while (salary[i] <= MinSalary);
                do
                {
                    Console.Write(AskIsIntern,i + 1,YesAnswer,NoAnswer);
                    yesOrNo = Convert.ToChar(Console.ReadLine());
                    if (yesOrNo == YesAnswer)
                    {
                        isIntern[i] = true;
                    }
                    else if (yesOrNo == NoAnswer)
                    {
                        isIntern[i] = false;
                    }
                } while (yesOrNo != YesAnswer && yesOrNo != NoAnswer);
            }

            for (int i = 0; i < AmountPeople; i++)
            {
                if(i==0)
                {
                    Console.WriteLine(TableHeader);
                }
                Console.WriteLine(age[i] + WordSpliter + sex[i] + WordSpliter + salary[i] + WordSpliter + (isIntern[i] ? YesAnswer: NoAnswer));
            }
        }
    }
}