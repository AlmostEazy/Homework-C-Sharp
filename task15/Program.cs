/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1 || n > 7) {
Console.WriteLine("В неделе 7 дней! Введите число от 1 до 7!");
} else if (n > 5) {
    Console.WriteLine("Выходной!");
} else {
    Console.WriteLine("На работу!");
}
