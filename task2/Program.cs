/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9 */


Console.Clear();

// 1 Вариант решения:

Console.WriteLine("Enter first number: ");
int numberOne = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int numberTwo = int.Parse(Console.ReadLine()!);

if (numberOne > numberTwo) 
Console.WriteLine($"{numberOne} - max and {numberTwo} - min");
else if (numberOne < numberTwo)
Console.WriteLine($"{numberTwo} - max and {numberOne} - min");
else 
Console.WriteLine($"{numberTwo} and {numberOne} are equal");


// 2 Вариант решения:

/* Console.WriteLine("Enter first number: ");
int numberOne = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int numberTwo = int.Parse(Console.ReadLine()!);

int max = numberOne;
int min = numberOne;

if (numberTwo > max) {
max = numberTwo;
Console.WriteLine($"{max} - max and {min} - min");
} else if (numberTwo < min) {
min = numberTwo;
Console.WriteLine($"{max} - max and {min} - min");
} else 
Console.WriteLine($"{max} and {min} are equal"); */


// 3 Вариант решения:

/* Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);

int [] arr = {a, b};
int max = arr[0];
int min = arr[0];

for (int i = 1; i < arr.Length; i++) {
    if (arr[i] > max) {
        max = arr[i];
        Console.WriteLine($"{max} - max and {min} - min");
    } else if (arr[i] < min) {
        min = arr[i];
        Console.WriteLine($"{max} - max and {min} - min");
    } else {
        Console.WriteLine($"{max} and {min} are equal");
    }        
} */

// С несколькими числами:

/* Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter third number: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter fourth number: ");
int d = int.Parse(Console.ReadLine()!);

int [] arr = {a, b , c, d}; 

int max = arr[0];
int min = arr[0];

for (int i = 1; i < arr.Length; i++) {
    if (arr[i] > max) {
        max = arr[i];
    } else if (arr[i] < min) {
        min = arr[i];
    }        
}
Console.WriteLine($"{max} - max and {min} - min"); */

// Со случайным массивом чисел:

/* void FillArray(int[] collection) {
    for (int i = 0; i < collection.Length; i++) {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] print) {
    for (int i = 0; i < print.Length; i++) {
        Console.WriteLine(print[i]);
    }
}

int [] arr = new int[15];

FillArray(arr);
PrintArray(arr);

int max = arr[0];
int min = arr[0];

for (int i = 1; i < arr.Length; i++) {
    if (arr[i] > max) {
        max = arr[i];
    } else if (arr[i] < min) {
        min = arr[i];
    }        
}
Console.WriteLine($"{max} - max and {min} - min"); */
