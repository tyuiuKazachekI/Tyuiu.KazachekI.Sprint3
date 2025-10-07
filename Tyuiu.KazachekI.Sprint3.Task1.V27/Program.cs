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
Console.WriteLine("*     5                                                                   *");
Console.WriteLine("* P = ∏ (1/n^k)³                                                          *");
Console.WriteLine("*    k=1                                                                  *");
Console.WriteLine("* при n = 0.75                                                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double n = 0.75;
int startValue = 1;
int stopValue = 5;

Console.WriteLine($"n = {n}");
Console.WriteLine($"Начальное значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetMultiplySeries(n, startValue, stopValue);

Console.WriteLine($"Произведение ряда = {result:F5}");

Console.ReadLine();