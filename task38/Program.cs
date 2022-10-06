/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

double [] CreateArray(int number) {
    double[] array = new double[number];
    return array;
}

void FillArray(double[] array) {
    for ( int i = 0; i < array.Length; i++) {
        array[i] = new Random().NextDouble();
    }
}

void PrintArray(double[] print) {
    Console.Write("[");
    for (int i = 0; i < print.Length; i++) {
        Console.Write(Math.Round(print[i], 2));
        if ( i != print.Length - 1 ) {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

(double, double) FindMaxAndMin(double[] array) {
    double max = array[0];
    double min = array[0];
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

double[] arr = CreateArray(n);
FillArray(arr);
PrintArray(arr);
var res = FindMaxAndMin(arr);
Console.WriteLine($"max: {Math.Round(res.Item1, 2)}, min: {Math.Round(res.Item2, 2)}");
Console.WriteLine($"Разность между максимальным элементом и минимальным: {Math.Round(res.Item1 - res.Item2, 2)}");
