using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                for (int div = 12; div <= num; div++)
                {
                    if (num % div == 0)
                    {
                        sum += div; 
                    }
                }
            }

            return sum;
        }
    }
}