using Tyuiu.ShmidtAA.Sprint3.Task4.V30.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #3 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = sin(x) / x. При x = 0 пропустить значение. Полученные       *");
            Console.WriteLine("* значения суммировать.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    x в диапазоне от -5 до 5                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            Console.WriteLine(ds.Calculate(-5,5));
        }
    }
}
