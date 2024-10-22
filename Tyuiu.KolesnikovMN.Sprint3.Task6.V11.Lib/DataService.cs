using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int j = startValue; j <= stopValue; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        if (i > 10)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
