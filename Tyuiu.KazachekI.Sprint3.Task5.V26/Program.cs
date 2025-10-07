using Tyuiu.KazachekI.Sprint3.Task5.V26.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить двойную сумму:                                                *");
Console.WriteLine("*     3     13                                                            *");
Console.WriteLine("* y = ∑     ∑  (x^k + sin(k))                                             *");
Console.WriteLine("*    i=1   k=1                                                            *");
Console.WriteLine("* при x = 2                                                               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 2;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 13;

Console.WriteLine($"X = {x}");
Console.WriteLine($"Внешняя сумма: i от {startValue1} до {stopValue1}");
Console.WriteLine($"Внутренняя сумма: k от {startValue2} до {stopValue2}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

Console.WriteLine($"Результат двойной суммы = {result:F5}");

Console.ReadLine();