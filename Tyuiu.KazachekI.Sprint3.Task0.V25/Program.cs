using Tyuiu.KazachekI.Sprint3.Task0.V25.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
Console.WriteLine("* по формуле, при X=5:                                                    *");
Console.WriteLine("*     14                                                                  *");
Console.WriteLine("* S = ∑ (4/(1 + x²))^i                                                    *");
Console.WriteLine("*    i=1                                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue = 1;
int stopValue = 14;

Console.WriteLine($"X = {x}");
Console.WriteLine($"Начальное значение i = {startValue}");
Console.WriteLine($"Конечное значение i = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"Сумма ряда = {result:F5}");

Console.ReadLine();