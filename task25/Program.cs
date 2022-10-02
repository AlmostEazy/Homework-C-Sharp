/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Clear();

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

if (b < 0) {
    Console.WriteLine("Введите натуральное число!");
} else {
    int result = Power(a, b);
    Console.WriteLine($"A в степени B = {result}");
}

int Power (int x, int y) {
    int count = 1;
    for (int i = 1; i <= y; i++) {
        count = count * x;
    }
    return count;
}

