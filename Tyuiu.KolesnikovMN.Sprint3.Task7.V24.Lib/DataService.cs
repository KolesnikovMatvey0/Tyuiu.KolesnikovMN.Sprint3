using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue);
            valueArray = new double[len];
            int count = 0;
            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
