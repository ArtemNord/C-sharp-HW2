// Напишите программу которая на входе принимает трехзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int result = (number % 100) / 10;

Console.Write ("Второе число: "); 
Console.Write (result);