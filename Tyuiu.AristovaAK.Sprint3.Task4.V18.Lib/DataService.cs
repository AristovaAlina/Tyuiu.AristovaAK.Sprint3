using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AristovaAK.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) break;
                res += (Math.Sin(i) / Math.Cos(i));

            }
            return Math.Round(res, 3);
        }
    }
}
