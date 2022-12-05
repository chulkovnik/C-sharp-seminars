// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

for ( int i = 1 ; i <= b;i++)
{
    double answer = Math.Pow(a,i);
    if (i == b) Console.WriteLine(Math.Round(answer,2));
}
