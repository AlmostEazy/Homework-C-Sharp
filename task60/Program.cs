/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

int[,,] CreateMatrix(int m, int n, int d) {
    int[,,] matrix = new int[m,n,d];
    return matrix;
}

int[] CreateArray(int m, int n, int d) {
    int[] array = new int[m*n*d];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(10, 100);
    }
    return array;
}

int[] CreateUniqueNumbers(int[] array) {
    int max = array[0];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        } 
    }
    for (int i = 0; i < array.Length; i++) {
        for (int j = i + 1; j < array.Length; j++) {
            if (array[j] == array[i]) {
                max++;
                array[j] = max;
            }
        }
    }
    return array;
}

void FillMatrix(int[,,] matrix, int[] array) {
    int l = 0;
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            for (int k = 0; k < matrix.GetLength(2); k++) {
                matrix[i,j,k] = array[l++];
            }
        }        
    }
}

void PrintMatrix(int[,,] matrix) {
    for ( int k = 0; k < matrix.GetLength(2); k++) {
        for ( int i = 0; i < matrix.GetLength(0); i++ ) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i,j,k]}{(i,j,k)} ");
            }
    Console.WriteLine();
        }
    }
}

void PrintArray(int[] print) {
    for (int i = 0; i < print.Length; i++) {
        Console.Write(print[i]);
        if ( i != print.Length - 1 ) {
            Console.Write(", ");
        }
    }
}

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите глубину массива: ");
int depth = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.WriteLine();
int[,,] newMatrix = CreateMatrix(row, column, depth);
int[] newArr = CreateArray(row, column, depth);
int[] unicArr = CreateUniqueNumbers(newArr);
Console.WriteLine("Набор неповторяющихся чисел: ");
PrintArray(unicArr);
FillMatrix(newMatrix, unicArr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел: ");
PrintMatrix(newMatrix);