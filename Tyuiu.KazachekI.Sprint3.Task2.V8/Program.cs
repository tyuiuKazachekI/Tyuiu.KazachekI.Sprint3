using Tyuiu.KazachekI.Sprint3.Task2.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле:                                           *");
Console.WriteLine("*     15                                                                  *");
Console.WriteLine("* P = ∏ [1/(cos(k) + 1)]²                                                 *");
Console.WriteLine("*    k=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 15;

Console.WriteLine($"Начальное значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetMultiplySeries(startValue, stopValue);

Console.WriteLine($"Произведение ряда = {result:F5}");

Console.ReadLine();