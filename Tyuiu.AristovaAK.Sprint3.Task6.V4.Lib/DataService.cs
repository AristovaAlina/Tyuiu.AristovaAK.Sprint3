using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AristovaAK.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int dels = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 10; d <= i; d++)
                {
                    if (i % d == 0)
                        dels += 1;
                }
            }
            return dels;
        }
    }
}
