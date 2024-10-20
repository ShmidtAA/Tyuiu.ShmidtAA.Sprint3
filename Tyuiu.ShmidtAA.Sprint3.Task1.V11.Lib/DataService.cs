using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShmidtAA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double composition = 1;
            while (startValue <= stopValue)
            {
                composition = composition * ((double)Math.Pow(value,startValue) + (0.5));
                startValue++;
            }
            return Math.Round(composition,3);
        }

    }
}
