using System;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1.0;
            int i = startValue;

            // Используем цикл while для вычисления произведения ряда
            while (i <= stopValue)
            {
                // Вычисляем первый элемент: cos(i)
                double cosTerm = Math.Cos(i);

                // Вычисляем второй элемент: (1/(1+i²))^i
                double denominator = 1 + Math.Pow(i, 2);
                double fraction = 1.0 / denominator;
                double powerTerm = Math.Pow(fraction, i);

                // Вычисляем множитель: cos(i) + (1/(1+i²))^i
                double multiplier = cosTerm + powerTerm;

                // Умножаем на текущее произведение
                product *= multiplier;

                i++;
            }

            return Math.Round(product, 5);
        }
    }
}