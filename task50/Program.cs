/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1
7 -> такого числа в массиве нет */

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
    
void ShowElement( int [,] matrix, int i, int j) {
    if ( i > matrix.GetLength(0) - 1 || j > matrix.GetLength(1) - 1 || i < 0 || j < 0) {
        Console.WriteLine("Такого числа в массиве нет");
    } else {
        Console.WriteLine($"Элемент искомой позиции: {matrix[i, j]}");
    }
}

Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);

Console.WriteLine("Введите искомую позицию (строка, колонна): ");
int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);

ShowElement(newMatrix, i, j);




