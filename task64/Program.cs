/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();

int OutputIntermediateNumbers(int number) {
    if (number < 1) {
        Console.WriteLine("Вы ввели не натуральное число");
        return number;
    }
    if (number == 1) {
        Console.Write($"{number}. ");
        return number;
    } else {
        Console.Write($"{number}, ");
        return OutputIntermediateNumbers(number - 1);
    }
}

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
OutputIntermediateNumbers(n);
