using Tyuiu.KolesnikovMN.Sprint3.Task1.V27.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double n = 0.75;
            int startValue = 1;
            int stopValue = 5;

            var res = ds.GetMultiplySeries(n, startValue, stopValue);
            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}