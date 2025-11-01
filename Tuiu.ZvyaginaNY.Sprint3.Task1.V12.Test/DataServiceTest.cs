using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task1.V12.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;          
            int startValue = 1;      
            int stopValue = 10;      

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.036;     

            Assert.AreEqual(wait, result);
        }
    }
}