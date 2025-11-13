using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task6.V20.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;
            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 39; 
            Assert.AreEqual(wait, result);
        }
    }
}