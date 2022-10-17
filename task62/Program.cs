/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int[,] CreateMatrix(int m, int n) {
    int[,] matrix = new int[m,n];
    return matrix;
}

void FillMatrix(int[,] matrix) {
    int firstNumber = 1;
    for (int j = 0; j < matrix.GetLength(1); j++) {
        matrix[0,j] = firstNumber;
        firstNumber++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++) {
        matrix[i, matrix.GetLength(1) - 1] = firstNumber;
        firstNumber++;
    }
    for (int j = matrix.GetLength(1) - 2; j >= 0; j--) {
        matrix[matrix.GetLength(0) - 1,j] = firstNumber;
        firstNumber++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--) {
        matrix[i,0] = firstNumber;
        firstNumber++;
    }

    int a = 1;
    int b = 1;

    while (firstNumber < matrix.GetLength(0) * matrix.GetLength(1)) {
        while (matrix[a, b + 1] == 0) {
            matrix[a,b] = firstNumber;
            firstNumber++;
            b++;
        }
        while (matrix[a + 1, b] == 0) {
            matrix[a,b] = firstNumber;
            firstNumber++;
            a++;
        }
        while (matrix[a, b - 1] == 0) {
            matrix[a,b] = firstNumber;
            firstNumber++;
            b--;
        }
        while (matrix[a - 1, b] == 0) {
            matrix[a,b] = firstNumber;
            firstNumber++;
            a--;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i,j] == 0) {
                matrix[i,j] = firstNumber;
            }
        }
    }
}

void PrintMatrix(int[,] matrix) {
    for ( int i = 0; i < matrix.GetLength(0); i++) {
        for ( int j = 0; j < matrix.GetLength(1); j++ ) {
            if (matrix[i,j] < 10) {
                Console.Write($"{matrix[i,j]}  ");
            } else {
                Console.Write($"{matrix[i,j]} ");
            }
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);