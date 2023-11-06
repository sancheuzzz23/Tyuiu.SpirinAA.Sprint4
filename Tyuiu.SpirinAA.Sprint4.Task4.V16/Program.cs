using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint4.Task4.V16.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task4.V16
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные элементы *");
            Console.WriteLine("* массива на 1.                                                           *");
            Console.WriteLine("* 6, 5, 6, 7, 3,                                                          *");
            Console.WriteLine("* 5, 4, 6, 7, 3,                                                          *");
            Console.WriteLine("* 5, 5, 5, 6, 5,                                                          *");
            Console.WriteLine("* 6, 5, 4, 4, 3,                                                          *");
            Console.WriteLine("* 4, 5, 4, 5, 5,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 6, 5, 6, 7, 3,                                                          *");
            Console.WriteLine("* 5, 4, 6, 7, 3,                                                          *");
            Console.WriteLine("* 5, 5, 5, 6, 5,                                                          *");
            Console.WriteLine("* 6, 5, 4, 4, 3,                                                          *");
            Console.WriteLine("* 4, 5, 4, 5, 5,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = new int[,] { { 6, 5, 6, 7, 3 },
                                      { 5, 4, 6, 7, 3 },
                                      { 5, 5, 5, 6, 5 },
                                      { 6, 5, 4, 4, 3 },
                                      { 4, 5, 4, 5, 5 } };

            var array = ds.Calculate(res);
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t", array[i, j]);

                }
            }
            Console.ReadKey();
        }
    }
}
