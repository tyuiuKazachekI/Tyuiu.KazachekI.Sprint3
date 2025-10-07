using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string numbersOnly = "";

            // Используем цикл foreach для перебора всех символов строки
            foreach (char c in value)
            {
                // Проверяем, является ли символ цифрой
                if (char.IsDigit(c))
                {
                    numbersOnly += c;
                }
            }

            // Преобразуем полученную строку с цифрами в число
            if (string.IsNullOrEmpty(numbersOnly))
            {
                return 0; // Если цифр нет, возвращаем 0
            }

            return int.Parse(numbersOnly);
        }
    }
}