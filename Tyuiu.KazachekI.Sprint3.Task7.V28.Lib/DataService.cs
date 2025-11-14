using System;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.KazachekI.Sprint3.Task7.V28.Lib
{
    public class DataService: ISprint3Task7V28 
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -2.5)
                {
                    resultArray[count] = 0;
                }
                else
                {
                    double part1 = Math.Cos(2 * x);
                    double part2 = Math.Sin(x) / (x + 2.5);
                    double part3 = 2 * x;

                    double functionValue = part1 + part2 + part3;
                    resultArray[count] = Math.Round(functionValue, 2);
                }

                count++;
            }

            return resultArray;
        }
    }
}