using Tyuiu.BaimuhametovaMD.Sprint4.Task3.V7.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] nums = { { 9, 6, 9, 3, 7 },
                { 3, 3, 3, 8, 2 },
                { 2, 1, 3, 5, 2 },
                { 6, 2, 3, 2, 5 },
                { 4, 5, 6, 9, 5 } };
            Console.Title = "Спринт #4 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до 9.              *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { 9, 6, 9, 3, 7 }                                                       *");
            Console.WriteLine("* { 3, 3, 3, 8, 2 }                                                       *");
            Console.WriteLine("* { 2, 1, 3, 5, 2 }                                                       *");
            Console.WriteLine("* { 6, 2, 3, 2, 5 }                                                       *");
            Console.WriteLine("* { 4, 5, 6, 9, 5 }                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Количество нечетных элементов массива равно " + ds.Calculate(nums));
            Console.ReadLine();
        }
    }
}
