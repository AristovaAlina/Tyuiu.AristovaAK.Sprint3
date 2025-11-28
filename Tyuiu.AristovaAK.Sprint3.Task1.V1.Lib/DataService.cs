using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AristovaAK.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            while (startValue <= stopValue)
            {
                res *= Math.Pow((3.0 / startValue), -2);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
