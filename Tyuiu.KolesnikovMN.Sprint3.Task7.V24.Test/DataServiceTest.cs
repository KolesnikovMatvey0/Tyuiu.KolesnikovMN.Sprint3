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
            valueWaitArray[1] = 6.22;
            valueWaitArray[2] = 6.36;
            valueWaitArray[3] = 6.96;
            valueWaitArray[4] = -0.52;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = -3.3;
            valueWaitArray[7] = -5.53;
            valueWaitArray[8] = -6.25;
            valueWaitArray[9] = -6.63;
            valueWaitArray[10] = -8.24;

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}