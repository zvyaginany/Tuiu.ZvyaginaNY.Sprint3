using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Lib;

namespace Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 13;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.875; 
            Assert.AreEqual(wait, result);
        }
    }
}