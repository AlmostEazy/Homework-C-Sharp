﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомый разряд: ");
int x = int.Parse(Console.ReadLine()!);


if ( n < Math.Pow(10, x - 1)) {
    Console.WriteLine("Третьей цифры нет");
} else if (n < Math.Pow(10, x)) {
    n = n % 10;
    Console.WriteLine(n);
} else {
    while ( n > Math.Pow(10, x - 1) ) {
        n = n / 10;
    }
    Console.WriteLine(n % 10);
}
