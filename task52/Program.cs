/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double[] calcArithmeticMean(int[,] matrix) {
    double[] array = new double[matrix.GetLength(1)];
    double count;
        for ( int j = 0; j < matrix.GetLength(1); j++) {
            count = 0;
            for ( int i = 0; i < matrix.GetLength(0); i++ ) {
                count = count + matrix[i, j];
            }
            array[j] = count / matrix.GetLength(0);
        }
        return array;
}

void PrintArray(double[] print) {
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < print.Length; i++) {
        Console.Write((Math.Round(print[i], 2)));
        if ( i != print.Length - 1 ) {
            Console.Write("; ");
        }
    }
}


Console.Write("Введите количество строк: ");
int row = (int)Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество колонн: ");
int column = (int)Math.Abs(int.Parse(Console.ReadLine()!));

int[,] newMatrix = CreateMatrix(row, column);
FillMatrix(newMatrix);
PrintMatrix(newMatrix);
double[] arr = calcArithmeticMean(newMatrix);
PrintArray(arr);

