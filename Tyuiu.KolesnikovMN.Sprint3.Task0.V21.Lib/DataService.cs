﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;
            for (; k < stopValue + 1; k++)
            {
                sumSeries += (Math.Pow(value, k) + 0.25) * Math.Sin(k);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
