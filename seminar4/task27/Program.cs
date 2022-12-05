// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0; 
double answer = 0;
 while ( Math.Floor(( (num % Math.Pow(10, count + 1 )) / Math.Pow(10, count ))) > 0)
{
    answer += Math.Floor(( (num % Math.Pow(10, count + 1 )) / Math.Pow(10, count ))) ;
    count ++;
  if (Math.Floor(( (num % Math.Pow(10, count + 1 )) / Math.Pow(10, count ))) == 0) Console.WriteLine(answer);
}