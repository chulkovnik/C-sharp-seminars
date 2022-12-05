//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
int digit = 0;
for (double i = 0; (num1 /  Math.Pow(10,i)) > 1;i++)
{
    digit = digit +1;
}
if (digit < 3) Console.Write("Третьей цифры нет");
else
{
    double answer = Math.Floor(num1 / Math.Pow(10,(digit - 2)));
Console.Write ($"третья цифра заданного числа – {answer}");
}