// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
                Console.Write("Числа равны");
} 
else 
{
                if (num1 > num2) 
                {
                    Console.Write($"{num1} больше {num2}");
                }
                else
                {
                    Console.Write($"{num2} больше {num1}");
                }

}
