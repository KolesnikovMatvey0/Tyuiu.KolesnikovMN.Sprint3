using Tyuiu.KolesnikovMN.Sprint3.Task0.V21.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;

            var res = ds.GetSumSeries(a, startValue, stopValue);
            double wait = -63.8;

            Assert.AreEqual(wait, res);
        }
    }
}