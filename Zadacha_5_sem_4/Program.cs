// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Numbers(int num)
{
    int com = 1;
    for(int i = 1; i <= num; i++) 
    com=com*i;
    return com;
}

Console.WriteLine ("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел от 1 до N  N = {num} -> {Numbers(num)}");