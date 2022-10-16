/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */

Console.Clear();

int[,] CreateMatrix(int m, int n) {
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

int[,] CalcMultiplication(int[,] matrix1, int[,] matrix2) {
    int[,] multiplyMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < multiplyMatrix.GetLength(0); i++) {
        for (int j = 0; j < multiplyMatrix.GetLength(1); j++) {
            multiplyMatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
    return multiplyMatrix;
}

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.WriteLine();
int[,] matrixOne = CreateMatrix(row, column);
FillMatrix(matrixOne);
PrintMatrix(matrixOne);
Console.WriteLine();
int[,] matrixTwo = CreateMatrix(row, column);
FillMatrix(matrixTwo);
PrintMatrix(matrixTwo);
Console.WriteLine();
Console.WriteLine("Их произведение будет равно следующему массиву: ");
int[,] resultMatrix = CalcMultiplication(matrixOne, matrixTwo);
PrintMatrix(resultMatrix);