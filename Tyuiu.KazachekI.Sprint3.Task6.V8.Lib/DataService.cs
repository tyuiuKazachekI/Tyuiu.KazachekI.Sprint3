using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            // Проходим по всем числам в диапазоне
            for (int num = startValue; num <= stopValue; num++)
            {
                // Находим все делители числа
                for (int divisor = 12; divisor <= num; divisor++) // Начинаем с 12, так как нужны делители > 11
                {
                    // Проверяем, является ли divisor делителем num
                    if (num % divisor == 0)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}