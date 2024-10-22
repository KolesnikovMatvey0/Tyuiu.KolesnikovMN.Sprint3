using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double mulSeries = 1;
            int k = startValue;
            do
            {
                mulSeries *= Math.Pow(k / Math.Sin(Math.Pow(1, -7)), -2);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(mulSeries, 3);
        }
    }
}
