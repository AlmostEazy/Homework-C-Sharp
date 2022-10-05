/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.Clear();

/* Для 8 элементов */
/* 
int [] CreateArrey() {
    int[] arr = new int [8];
    return arr;
}

void FillArrey(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(int.MinValue, int.MaxValue);
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
}

int[] arrey = CreateArrey();
FillArrey(arrey);
PrintArray(arrey); */

/* Для любой длины массива */

int [] CreateArray( int n ) {
    int[] arr = new int [n];
    return arr;
}

void FillArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(int.MinValue, int.MaxValue);
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
}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);

int[] array = CreateArray(a);
FillArray(array);
PrintArray(array);