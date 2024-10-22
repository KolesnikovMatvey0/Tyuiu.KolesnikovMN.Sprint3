using Tyuiu.KolesnikovMN.Sprint3.Task4.V1.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Колесников М. Н. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Колесников Матвей Николаевич | РППб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("*  функции y=sin(x)/x. При х = 0 прервать цикл. Полученные значения       *");
            Console.WriteLine("*  суммировать.                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {ds.Calculate(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
