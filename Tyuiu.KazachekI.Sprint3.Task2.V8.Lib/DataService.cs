using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            // Используем цикл do...while для вычисления произведения ряда
            do
            {
                // Вычисляем cos(k)
                double cosK = Math.Cos(k);

                // Вычисляем cos(k) + 1
                double denominator = cosK + 1;

                // Проверка деления на ноль (на всякий случай)
                if (Math.Abs(denominator) < 0.0001)
                {
                    throw new ArgumentException($"Знаменатель равен нулю при k={k}");
                }

                // Вычисляем 1/(cos(k) + 1)
                double fraction = 1.0 / denominator;

                // Возводим в квадрат: [1/(cos(k) + 1)]²
                double term = Math.Pow(fraction, 2);

                // Умножаем на текущее произведение
                product *= term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 5);
        }
    }
}