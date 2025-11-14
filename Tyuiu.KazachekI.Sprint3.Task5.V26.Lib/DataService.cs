using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task5.V26.Lib
{

        public class DataService : ISprint3Task5V26
        {
            public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
            {
                double totalSum = 0;

                for (int i = startValue1; i <= stopValue1; i++)
                {
                    double sumForI = 0;

                    for (int k = startValue2; k <= stopValue2; k++)
                    {
                        double power = Math.Pow(x, k);
                        double sinus = Math.Sin(k);
                        sumForI += power + sinus;
                    }

                    totalSum += sumForI;
                }

                return Math.Round(totalSum, 3);
            }
        }
    }
