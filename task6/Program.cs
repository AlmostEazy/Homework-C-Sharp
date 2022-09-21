/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Clear();

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine()!);

string result;

result = a % 2 == 0 ? $"Число {a} чётное" : $"Число {a} не чётное";

Console.WriteLine(result);