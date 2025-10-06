using Tyuiu.KazachekI.Sprint3.Task1.V27.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
Console.WriteLine("* ряда по формуле:                                                        *");
Console.WriteLine("*     10                                                                  *");
Console.WriteLine("* P = ∏ [cos(i) + (1/(1+i²))^i]                                           *");
Console.WriteLine("*    i=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double value = 0.75;
int startValue = 1;
int stopValue = 10;

Console.WriteLine($"Значение = {value}");
Console.WriteLine($"Начальное значение i = {startValue}");
Console.WriteLine($"Конечное значение i = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetMultiplySeries(value, startValue, stopValue);

Console.WriteLine($"Произведение ряда = {result:F5}");

Console.ReadLine();