﻿using Tyuiu.KazachekI.Sprint3.Task7.V28.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Табулирование функции                                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу которая выводит таблицу значений функции:            *");
Console.WriteLine("* f(x) = cos(2x) + sin(x)/(x+2.5) + 2x                                    *");
Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5, 5] с шагом 1.           *");
Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
Console.WriteLine("* Значение округлить до 2 знаков после запятой.                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine($"Начало диапазона: {startValue}");
Console.WriteLine($"Конец диапазона: {stopValue}");
Console.WriteLine($"Шаг: 1");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double[] result = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    x     |   f(x)    |");
Console.WriteLine("+----------+-----------+");

for (int i = 0; i < result.Length; i++)
{
    int x = startValue + i;
    Console.WriteLine($"| {x,5}    | {result[i],8:F2} |");
}

Console.WriteLine("+----------+-----------+");

Console.ReadLine();