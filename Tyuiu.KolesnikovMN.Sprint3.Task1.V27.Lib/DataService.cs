using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double mulSeries = 1;
            int k = startValue;
            while(k <= 5)
            {
                mulSeries *= Math.Pow(1.0 / Math.Pow(value, k), 3);
                k++;
            }
            return Math.Round(mulSeries, 3);
        }
    }
}
