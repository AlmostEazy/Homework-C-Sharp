/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int ElemetsSum(int numberOne, int numberTwo, int sum = 0) {
    if (numberOne == numberTwo) {
        sum = numberOne;
        return sum;
    } else if (numberOne < numberTwo) {
        sum = numberTwo + ElemetsSum(numberOne, numberTwo - 1);
        return sum;
    } else {
        sum = numberTwo + ElemetsSum(numberOne, numberTwo + 1);
        return sum;
    }
}

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(ElemetsSum(m, n));