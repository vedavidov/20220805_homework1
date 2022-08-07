//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое чилсо: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чилсо: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Большее число: "); 
    Console.WriteLine(numberA);
    Console.Write("Меньшее число: "); 
    Console.WriteLine(numberB);
}

if (numberB > numberA)
{
    Console.Write("Большее число: "); 
    Console.WriteLine(numberB);
    Console.Write("Меньшее число: "); 
    Console.WriteLine(numberA);
}

if (numberB == numberA)
{
    Console.Write("Извините, числа равны. Повторите ввод!"); 
}