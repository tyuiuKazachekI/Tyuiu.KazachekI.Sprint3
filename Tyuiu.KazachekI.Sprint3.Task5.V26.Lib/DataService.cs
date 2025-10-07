using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            // Внешний цикл по i
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;

                // Внутренний цикл по k
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Вычисляем x^k
                    double x_power_k = Math.Pow(x, k);

                    // Вычисляем sin(k)
                    double sin_k = Math.Sin(k);

                    // Суммируем: x^k + sin(k)
                    double term = x_power_k + sin_k;

                    innerSum += term;
                }

                // Добавляем внутреннюю сумму к общей сумме
                totalSum += innerSum;
            }

            return Math.Round(totalSum, 5);
        }
    }
}