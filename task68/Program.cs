/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int CalcAkkerman(int numberOne, int numberTwo) {
    if (numberOne == 0) {
        return numberTwo + 1;
    } else if (numberTwo == 0) {
        return CalcAkkerman(numberOne - 1, 1);
    } else {
        return CalcAkkerman(numberOne - 1, CalcAkkerman(numberOne, numberTwo - 1));
    }
}

Console.Write("Введите число M: ");
int m = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите число N: ");
int n = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write($"A({m}, {n}) = {CalcAkkerman(m, n)}");