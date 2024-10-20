using Tyuiu.ShmidtAA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint3.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 
            Console.WriteLine(ds.GetMultiplySeries(0.75, 1, 14));
        }
    }
}
