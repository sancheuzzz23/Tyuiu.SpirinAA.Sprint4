using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint4.Task0.V11.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task0.V11
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Произведение нечетных элементов массива = {ds.GetMultOddArrEl(array)}");

            Console.ReadKey(); 
        }
    }
}
