using System;

namespace Podminky
{
    class Program
    {
        /*Napíš program, ktorý vytvorí priemer zo známok(ľubovoľný počet int-ov) a na konzolu za pomoci switch
            u napíš akú známku bude na vysvedčení. Ak je priemer > 1.5 tak na vysvedčení bude 2.
            Ak je priemer<ako 1.5, tak na vysvedčení bude 1, takto to sprav pre všetky známky.*/

        static void Main(string[] args) //hlavni cast programu - prumer znamek
        {
            int constant1;
            Console.Write("Zadej počet známek: ");
            constant1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] fieldOfStamps1 = new int[constant1];

            ReadField(ref fieldOfStamps1);
            Console.WriteLine();
            Console.WriteLine($"Průměr zadaných {fieldOfStamps1.Length} známek je {GiveAverage(fieldOfStamps1)}.");
            Console.WriteLine();
            Console.WriteLine($"Známka na vysvědčení bude {FinalGrade(GiveAverage(fieldOfStamps1))}.");
        }

        static void ReadField(ref int[] fieldOfStamps) //cyklus do-while vycet hodnot
        {
            int i = 1;
            do
            {
                Console.Write($"Zadej {i}. známku: ");
                fieldOfStamps[i - 1] = int.Parse(Console.ReadLine());
                i++;
            }
            while (i < fieldOfStamps.Length + 1);
        }

        static float GiveAverage(int[] fieldOfStamps) //prumer (sum] hodnot z cyklu (for)
        {
            int Suma = 0;
            float result;
            for (int i = 0; i < fieldOfStamps.Length; i++)
            {
                Suma = Suma + fieldOfStamps[i];
            }
            result = (float)Suma / fieldOfStamps.Length;
            return result;
        }

        static int FinalGrade(float finalAverage) //podminka if/else if/else vyhodnoceni znamky na vysvedceni
        {
            int result;
            if (finalAverage < 1.5)
                result = 1;
            else if ((finalAverage >= 1.5) && (finalAverage < 2.5))
                result = 2;
            else if ((finalAverage >= 2.5) && (finalAverage < 3.5))
                result = 3;
            else if ((finalAverage >= 3.5) && (finalAverage < 4.5))
                result = 4;
            else
                result = 5;
            return result;
        }
    }

}

