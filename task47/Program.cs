/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Clear();

double[,] CreateMatrix( int m, int n) {
    double[,] matrix = new double[m,n];
    return matrix;
}

void FillMatrix(double[,] matrix) {
    Random rand = new Random();
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            matrix[i,j] = rand.Next(-10, 11) + rand.NextDouble();
        }        
    }
}

void PrintMatrix(double[,] matrix) {
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            Console.Write($"{Math.Round(matrix[i,j], 1)} ");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

double[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
