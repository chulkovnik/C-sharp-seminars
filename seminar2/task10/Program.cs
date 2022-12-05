// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
double num1 = Convert.ToInt32(Console.ReadLine());
while (num1 / 100 > 10 || num1 / 100 < 1) 
{
    Console.Write("Введите трехзначное число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
double result = Math.Floor ((num1 % 100) / 10);
Console.Write(result);
