using Tyuiu.AristovaAK.Sprint3.Task1.V1.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 7;
            double wait = 5.311;
            Assert.AreEqual(wait, ds.GetMultiplySeries(start, stop));
        }
    }
}
