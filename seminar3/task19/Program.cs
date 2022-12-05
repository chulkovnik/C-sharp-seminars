Console.Write("Введите пятизначное число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
while (num1 / 10000 > 10 || num1 / 10000 <1)
{
    Console.Write("Введите натуральное пятизначное число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
double check1 = Math.Floor(num1 / 10000);
double check2 = Math.Floor((Math.Floor(num1 / 1000) % 10));
double check3 = Math.Floor((num1 % 100)/10);
double check4 = num1 % 10;
if (check1 == check4 || check2 == check3) Console.WriteLine("Да");
else Console.WriteLine("Нет");
