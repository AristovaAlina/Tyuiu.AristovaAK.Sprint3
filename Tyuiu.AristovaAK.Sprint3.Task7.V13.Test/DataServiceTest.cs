using Tyuiu.AristovaAK.Sprint3.Task7.V13.Lib;
namespace Tyuiu.AristovaAK.Sprint3.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;

            double[] wait = new double[len];
            wait[0] = -9.1;
            wait[1] = 1.55; 
            wait[2] = 292.78;
            wait[3] = -0.57;
            wait[4] = -0.35;
            wait[5] = 2;
            wait[6] = 4.35;
            wait[7] = 4.57;
            wait[8] = -288.78;
            wait[9] = 2.45;
            wait[10] = 13.1;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);

        }
    } 
}
