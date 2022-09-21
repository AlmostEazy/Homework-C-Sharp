/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();

/* Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);

for (int count = 2; count <= n; count += 2) {
    Console.WriteLine(count);
}
if (n <= 1)
Console.WriteLine("По условию задачи числа должны быть больше 1"); */

/* 2 Вариант, если следовать условию задачи от 1 до N */

Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine()!);

for (int count = 1; count <= n; count++) {
    if (count % 2 == 0)
    Console.WriteLine(count);
} 
if (n <= 1)
Console.WriteLine("По условию задачи числа должны быть не меньше 1, а 1 - нечётное, введите число больше 1");