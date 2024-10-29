using Tyuiu.BaimuhametovaMD.Sprint4.Task6.V6.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            Console.Title = "Спринт #4 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 5 символам.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { \"Борис\", \"Анна\", \"Михаил\", \"Ирина\", \"Сергей\", \"Татьяна\", \"Олег\" }     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(names);

            Console.Write("Элементы массива, имеющие длину 5 символов: ");
            for (int i = 0; i < res.Length; i++) { Console.Write(res[i] + " "); }
            Console.ReadLine();
        }
    }
}
