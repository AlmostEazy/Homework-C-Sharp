/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] SortMatrix(int[,] matrix) {
    for (int repeat = 0; repeat < matrix.GetLength(1); repeat++) {
        for ( int i = 0; i < matrix.GetLength(0); i++) {
            for ( int j = 0, l = 1; l < matrix.GetLength(1); j++, l++) {
                if (matrix[i, j] < matrix[i,l]) {
                    int k = matrix[i,j];
                    matrix[i,j] = matrix[i,l];
                    matrix[i,l] = k;
                }
            } 
        }
    }
    return matrix;
}


Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
int[,] result = SortMatrix(newMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);
