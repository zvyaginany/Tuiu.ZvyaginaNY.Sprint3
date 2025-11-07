using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Lib;

namespace Tuyu.ZvyaginaNY.Sprint3.Task2.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double expected = 109.292;

            
            double actual = ds.GetMultiplySeries(value, startValue, stopValue);

            
            Assert.AreEqual(expected, actual, 0.001, "Произведение ряда вычислено неверно");
        } 

        [TestMethod]
        public void CheckRangeParameters()
        {
            
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 5;

            
            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            
            
            Assert.IsTrue(result > 3.4 && result < 3.6, "Результат для диапазона 1-5 неверен");
        }

        [TestMethod]
        public void TestSingleIteration()
        {

            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 1;
            double expected = 1.5; 

            
            double actual = ds.GetMultiplySeries(value, startValue, stopValue);

            
            Assert.AreEqual(expected, actual, 0.001, "Одна итерация вычислена неверно");
        }

        [TestMethod]
        public void TestWithDifferentValue()
        {
           
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 3;

            
            double result = ds.GetMultiplySeries(value, startValue, stopValue);

           
            
           
            
           
            Assert.IsTrue(result > 89 && result < 90, "Результат для t=2 неверен");
        }
    }
}