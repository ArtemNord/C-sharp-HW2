﻿// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает что, третьей цифры нет.
Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 100) Console.WriteLine ("Третьей цифры нет.");

else {
    string array = number.ToString();
    Console.Write ("Третья цифра: ");
    Console.Write (array [2]);
    }