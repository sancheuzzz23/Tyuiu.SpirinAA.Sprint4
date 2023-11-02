using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint4.Task3.V6.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Спирин А. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите максимальный     *");
            Console.WriteLine("* элемент во второй строке массива.                                       *");
            Console.WriteLine("* 8, 8, 3, 4, 5,                                                          *");
            Console.WriteLine("* 8, 6, 6, 4, 6,                                                          *");
            Console.WriteLine("* 3, 6, 5, 3, 4,                                                          *");
            Console.WriteLine("* 5, 6, 3, 7, 5,                                                          *");
            Console.WriteLine("* 7, 8, 5, 6, 6,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mas2 = new int[5, 5] { { 8, 8, 3, 4, 5 },
                                          { 8, 6, 6, 4, 6 },
                                          { 3, 6, 5, 3, 4 },
                                          { 5, 6, 3, 7, 5 },
                                          { 7, 8, 5, 6, 6 } };

            Console.Write("Массив:{ ");
            for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < mas2.Length / (mas2.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(mas2[i, j]);
                    if (j != mas2.GetLength(0) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != mas2.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine(" }");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);

            Console.WriteLine("Максимальный элемент во второй строке массива = " + res);
            Console.ReadKey();
        }
    }
}
