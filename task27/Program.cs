/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Clear();

Console.Write("Введите число N: ");
int n = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int Sum ( int x ) {
    int count = 0;
    while ( x >= 1 ) {
        int y = x % 10;
        count = count + y;
        x = x / 10;
    }
    return count;
}

int result = Sum(n);
Console.WriteLine($"Сумма цифр числa N: {result}");
