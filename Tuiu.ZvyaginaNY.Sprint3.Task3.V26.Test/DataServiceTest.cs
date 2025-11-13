using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint3.Task3.V26.Lib;

namespace Tuiu.ZvyaginaNY.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'e';
            int result = ds.GetCharCount(value, item);
            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}