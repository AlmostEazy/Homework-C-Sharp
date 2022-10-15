/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1) */

Console.Clear();

int[,] CreateMatrix( int m, int n) {
    int[,] matrix = new int[m,n];
    return matrix;
}

void FillMatrix(int[,] matrix) {
    Random rand = new Random();
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            matrix[i,j] = rand.Next(0, 11);
        }        
    }
}

void PrintMatrix(int[,] matrix) {
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[] CalcRowSum(int[,] matrix) {
    int[] array = new int[matrix.GetLength(0)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            count = count + matrix[i,j];
        }
        array[i] = count;
        count = 0;
    }
    return array;
}

int CalcMinRowSum(int[] array) {
    int min = array[0];
    int minIndex = 0;
        for (int i = 1; i < array.Length; i++) {
        if (array[i] < min) {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
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

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
int[] sum = CalcRowSum(newMatrix);
Console.Write("Сумма по строкам: ");
PrintArray(sum);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {CalcMinRowSum(sum) + 1} строка");


