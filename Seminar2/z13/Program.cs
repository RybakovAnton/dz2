﻿// Напишиите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while(num>=1000)
    {
        num=num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}

