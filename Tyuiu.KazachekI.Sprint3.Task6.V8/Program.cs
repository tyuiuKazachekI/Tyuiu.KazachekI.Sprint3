using Tyuiu.KazachekI.Sprint3.Task6.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [18, 28] сумму всех делителей больше 11.              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 18;
int stopValue = 28;

Console.WriteLine($"Начало диапазона: {startValue}");
Console.WriteLine($"Конец диапазона: {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetSumTheDivisors(startValue, stopValue);

Console.WriteLine($"Сумма всех делителей больше 11 = {result}");

Console.ReadLine();