using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task5.V26.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 13;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 24597.579;
            Assert.AreEqual(wait, result);
        }
    }
}