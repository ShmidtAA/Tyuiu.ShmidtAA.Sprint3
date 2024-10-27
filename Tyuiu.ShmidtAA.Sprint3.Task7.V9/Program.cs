using Tyuiu.ShmidtAA.Sprint3.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*                F(x) = (2x - 3) / (cos(x) - 2 * x) + 5 * x - sin(x)      *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
            Console.WriteLine("* Проверить деление на ноль. При делении на ноль вернуть значение 0.      *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    Диапазон: [-5; 5], шаг: 1                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            int len = ds.GetMassFunction(startValue, endValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, endValue);

            Console.WriteLine("+-------+-------+");
            Console.WriteLine("|   x   |  f(x) |");
            Console.WriteLine("+-------+-------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,5:d} | {1,5:f2} |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+-------+-------+");
            Console.ReadKey();








        }
    }
}
