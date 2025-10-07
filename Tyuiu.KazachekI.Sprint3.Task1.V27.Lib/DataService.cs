using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            // Используем цикл while для вычисления произведения ряда
            while (k <= stopValue)
            {
                // Вычисляем n^k
                double n_power_k = Math.Pow(value, k);

                // Вычисляем 1/n^k
                double fraction = 1.0 / n_power_k;

                // Возводим в куб: (1/n^k)³
                double term = Math.Pow(fraction, 3);

                // Умножаем на текущее произведение
                product *= term;

                k++;
            }

            // Округляем до 1 знака после запятой как в ожидаемом результате
            return Math.Round(product, 1);
        }
    }
}