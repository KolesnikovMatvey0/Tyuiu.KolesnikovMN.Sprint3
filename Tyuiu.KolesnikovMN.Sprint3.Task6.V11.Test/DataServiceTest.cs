using Tyuiu.KolesnikovMN.Sprint3.Task6.V11.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 19;

            var res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 9;

            Assert.AreEqual(wait, res);
        }
    }
}