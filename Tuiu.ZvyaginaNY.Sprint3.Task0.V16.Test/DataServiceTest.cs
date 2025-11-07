using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task0.V16.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(5, 1, 6);

            // Правильный расчет:
            // (5/1)³ = 125
            // (5/2)³ = 15.625
            // (5/3)³ ≈ 4.62963
            // (5/4)³ = 1.953125
            // (5/5)³ = 1
            // (5/6)³ ≈ 0.578704
            // Произведение: 125 × 15.625 × 4.62963 × 1.953125 × 1 × 0.578704 ≈ 1025.749
            double wait = 1025.749;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesWithDifferentRange()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(5, 1, 3);

            // (5/1)³ × (5/2)³ × (5/3)³ = 125 × 15.625 × 4.62963 ≈ 9047.009
            double wait = 9047.009;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesSingleTerm()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(5, 2, 2);

            // (5/2)³ = 15.625
            double wait = 15.625;

            Assert.AreEqual(wait, res);
        }
    }
}