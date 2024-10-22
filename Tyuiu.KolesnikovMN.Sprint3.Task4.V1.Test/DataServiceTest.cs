using System.Runtime.Serialization;
using Tyuiu.KolesnikovMN.Sprint3.Task4.V1.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            var res = ds.Calculate(startValue, stopValue);
            double wait = 0.962;

            Assert.AreEqual(wait, res);
        }
    }
}