using Tyuiu.AristovaAK.Sprint3.Task6.V4.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 14;
            int stop = 20;
            int wait = 8;
            int res = ds.GetSumTheDivisors(start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
