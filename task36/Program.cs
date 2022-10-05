
/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

int [] CreateArray(int number) {
    int[] array = new int[number];
    return array;
}

void FillArray(int[] array) {
    for ( int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-100, 101);
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

int OddPositionElementsSum(int[] array) {
    int count = 0;
    for ( int i = 1; i < array.Length; i +=2) {
        count = count + array[i];
    }
    return count;
}

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] arr = CreateArray(n);
FillArray(arr);
PrintArray(arr);
int result = OddPositionElementsSum(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях: {result}");
