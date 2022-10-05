/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

int [] CreateArray(int number) {
    int[] array = new int[number];
    return array;
}

void FillArray(int[] array) {
    for ( int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] print) {
    Console.Write("[");
    for (int i = 0; i < print.Length; i++) {
        Console.Write(print[i]);
        if ( i != print.Length - 1 ) {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int EvenNumbersCount(int[] array) {
    int count = 0;
    for ( int i = 0; i < array.Length; i++) {
        if ( array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] arr = CreateArray(n);
FillArray(arr);
PrintArray(arr);
int result = EvenNumbersCount(arr);
Console.WriteLine($"Количество четных чисел в массиве: {result}");