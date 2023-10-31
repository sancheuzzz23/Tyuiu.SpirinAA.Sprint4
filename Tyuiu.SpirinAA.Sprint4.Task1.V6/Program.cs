using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint4.Task1.V6.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task1.V6
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 7 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 2, 4, 4, 7, 2, 5, 4, 3, 3, 4    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите количество элемнтов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0;i < len; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
