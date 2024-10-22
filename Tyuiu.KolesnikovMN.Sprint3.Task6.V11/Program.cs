using Tyuiu.KolesnikovMN.Sprint3.Task6.V11.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("*  числовому отрезку [10, 19] количество всех делителей больше 10         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 19;

            Console.WriteLine($"Старт отрезка = {startValue}");
            Console.WriteLine($"Конец отрезка = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма делителей = {ds.GetSumTheDivisors(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
