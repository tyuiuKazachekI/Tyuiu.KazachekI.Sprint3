using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                double cosX = Math.Cos(x);
                if (Math.Abs(cosX) < 0.0001)
                {
                    continue; 
                }

                double y = (x / cosX) + 1.5;

                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}