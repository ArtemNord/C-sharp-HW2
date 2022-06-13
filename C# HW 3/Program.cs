// Напишите программу которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write ("Введите день недели в ввиде цифры по порядку от 1го до 7ми: ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number == 1) Console.Write ("Понедельник");
if (number == 2) Console.Write ("Вторник");
if (number == 3) Console.Write ("Среда");
if (number == 4) Console.Write ("Четверг");
if (number == 5) Console.Write ("Пятница");
if (number == 6) Console.Write ("Суббота");
if (number == 7) Console.Write ("Воскресенье");

if (number < 6) Console.Write (" - Рабочий день");
    else Console.Write (" - Выходной");

if Console.Write ("Введите число от 1го до 7ми.");
