using Tyuiu.BaimuhametovaMD.Sprint4.Task4.V11.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 5 до 8.              *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];
            string str;
            string[] sep = new string[5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("Введите значения {0} строки массива через пробел: ", i+1);
                str = Console.ReadLine();
                sep = str.Split(' ');
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(sep[j]);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма нечетных элементов массива равна " + ds.Calculate(array));
            Console.ReadLine();
        }
    }
}
