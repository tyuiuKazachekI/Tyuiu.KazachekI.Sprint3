using Tyuiu.KazachekI.Sprint3.Task4.V7.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов break и continue в циклах               *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y = (x/cos(x)) + 1.5. При х = 0 прервать цикл.                  *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine($"Начальное значение x = {startValue}");
Console.WriteLine($"Конечное значение x = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(startValue, stopValue);

Console.WriteLine($"Произведение значений функции = {result:F5}");

Console.ReadLine();