// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Write("Введите порядковый номер дня недели: ");
double num1 = Convert.ToInt32(Console.ReadLine());
while (num1 > 7 || num1 < 1) 
{
    Console.Write("В неделе 7 дней. Введите порядковый номер дня недели: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
if (num1 == 6 || num1 == 7) Console.Write("Выходной день,ура!");
else Console.Write("Будний день, работаем");