// Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountIndex (int arg)
{
    int count = 0;
    while (arg>=1)
    {
        arg = arg/10;
        count++;
    } 
    return count;
}

Console.WriteLine("Введите любое целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел в {num} -> {CountIndex(num)}");
