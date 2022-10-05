/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

float [] CreateArray(int number) {
    float[] array = new float[number];
    return array;
}

void FillArray(float[] array) {
    for ( int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(float[] print) {
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

(float, float) FindMaxAndMin(float[] array) {
    float max = array[0];
    float min = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        } else if (array[i] < min) {
            min = array[i];
        }
    }
    var result = (max, min);  // кортеж
    return result;
}

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

float[] arr = CreateArray(n);
FillArray(arr);
PrintArray(arr);
var result = FindMaxAndMin(arr);
Console.WriteLine($"max: {result.Item1}, min: {result.Item2}");
Console.WriteLine($"Разность между максимальным элементом и минимальным: {result.Item1 - result.Item2}");
