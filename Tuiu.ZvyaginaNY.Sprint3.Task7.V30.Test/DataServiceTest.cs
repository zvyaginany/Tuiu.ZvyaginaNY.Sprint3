using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task7.V30.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task7.V30.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = {
                -12.76, -9.87, -7.41, -4.83, -2.50,
                2.50, 4.83, 7.41, 9.87, 12.76, 16.07
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}