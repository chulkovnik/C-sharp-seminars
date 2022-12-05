//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int SIZE = 8;
int [] arr = new int [SIZE];

Console.WriteLine($"Введите {SIZE} чисел:");

for (int i = 0; i < SIZE; i++)
{
    arr [i] = Convert.ToInt32(Console.ReadLine());
    if (i == SIZE - 1 ) {
        Console.Write("[");
        for ( int count = 0; count < SIZE - 1 ; count++)
         {
            Console.Write($"{arr[count]},");
         };
         Console.Write($"{arr[SIZE - 1]}]");

    };
};


