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
                // Проверяем, если x = 0, прерываем цикл
                if (x == 0)
                {
                    break;
                }

                // Проверяем деление на ноль в косинусе
                double cosX = Math.Cos(x);
                if (Math.Abs(cosX) < 0.0001)
                {
                    continue; // Пропускаем итерацию при cos(x) близком к 0
                }

                // Вычисляем значение функции: y = (x/cos(x)) + 1.5
                double y = (x / cosX) + 1.5;

                // Умножаем на текущее произведение
                product *= y;
            }

            return Math.Round(product, 5);
        }
    }
}