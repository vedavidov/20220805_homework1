//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите значение чилса N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i = i + 1)
    if (i % 2 == 0)   

Console.WriteLine(i);
Console.WriteLine("*Выше указаны чётные числа диапазона от 1 до N");