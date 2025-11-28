using Tyuiu.AristovaAK.Sprint3.Task2.V4.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 9;
            double wait = 0.021;
            Assert.AreEqual(wait, ds.GetMultiplySeries(start, stop));
        }
    }
}
