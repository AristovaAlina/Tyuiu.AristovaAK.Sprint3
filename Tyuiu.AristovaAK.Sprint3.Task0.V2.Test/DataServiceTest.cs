using Tyuiu.AristovaAK.Sprint3.Task0.V2.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double wait = 0.021;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
