using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShmidtAA.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double amount = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                amount += Math.Pow(((1) / (Math.Sin(i) + 2 * (Math.Pow(value, i)))), i);

            }

            return Math.Round(amount, 3);
        }
    }
}
