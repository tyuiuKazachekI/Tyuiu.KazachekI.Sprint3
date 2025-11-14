using Tyuiu.KazachekI.Sprint3.Task3.V13.Lib;

Console.Title = "Спринт #3 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
Console.WriteLine("* цифру затем преобразовать в число в строке: '?sd!! 5gh. s!'             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "?sd!! 5gh. s!";
Console.WriteLine($"Исходная строка: '{value}'");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.ConvertStringToInt(value);

Console.WriteLine($"Полученное число: {result}");

Console.ReadLine();