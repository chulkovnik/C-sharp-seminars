// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < a; i++)
{
    count++;   
    Console.Write($"{Math.Pow(count,3)}, ");
}