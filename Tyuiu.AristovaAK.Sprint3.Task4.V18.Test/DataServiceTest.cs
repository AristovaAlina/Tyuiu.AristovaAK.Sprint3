using Tyuiu.AristovaAK.Sprint3.Task4.V18.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double wait = 2.993;
            double res = ds.Calculate(start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
