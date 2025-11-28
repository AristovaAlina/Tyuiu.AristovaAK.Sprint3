using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AristovaAK.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                res *= Math.Pow(((k) / (Math.Pow(Math.Sin(1), -7))), -2);
            }
            return Math.Round(res, 3);
        }
    }
}
