using Microsoft.VisualBasic;
using Tyuiu.AristovaAK.Sprint3.Task5.V4.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 13;
            int x = 5;
            double wait = 3328.185;
            double res = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);
            Assert.AreEqual(wait, res);

        }
    }
}
