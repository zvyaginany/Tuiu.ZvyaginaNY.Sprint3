using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task4.V27.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task4.V27.Test
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
            double result = ds.Calculate(startValue, stopValue);
            double wait = 0.000; 
            Assert.AreEqual(wait, result);
        }
    }
}