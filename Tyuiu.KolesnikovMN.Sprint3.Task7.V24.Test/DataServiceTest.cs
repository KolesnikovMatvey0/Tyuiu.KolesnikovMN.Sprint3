using Tyuiu.KolesnikovMN.Sprint3.Task7.V24.Lib;

namespace Tyuiu.KolesnikovMN.Sprint3.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray = new double[len];

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            valueWaitArray[0] = 7.83;
            valueWaitArray[1] = 6.21;
            valueWaitArray[2] = 6.36;
            valueWaitArray[3] = 6.96;
            valueWaitArray[4] = 3;
            valueWaitArray[5] = 3;
            valueWaitArray[6] = 3;
            valueWaitArray[7] = 3;
            valueWaitArray[8] = 3;
            valueWaitArray[9] = 3;

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}