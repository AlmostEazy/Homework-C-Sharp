/* Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3 */

Console.Clear();

/* С запоминанием введенных чисел */
/* 
int [] CreateArray(int number) {
    int[] array = new int[number];
    return array;
}

void FillArray(int[] array) {
    for ( int i = 0; i < array.Length; i++) {
        int enterNumber = int.Parse(Console.ReadLine()!);
        array[i] = enterNumber;
    }
}

void PrintArray(int[] print) {
    for (int i = 0; i < print.Length; i++) {
        Console.Write(print[i]);
        if ( i != print.Length - 1 ) {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int countNumbersGreaterZero(int[] array) {
    int count = 0;
    for ( int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            count++;
        }
    }
    return count;
}

Console.Write("Введите число M: ");
int numberM = Math.Abs(int.Parse(Console.ReadLine()!));

int[] arr = CreateArray(numberM);
Console.WriteLine("Ведите M чисел: ");
FillArray(arr);
Console.Write("Вы ввели: ");
PrintArray(arr);
int result = countNumbersGreaterZero(arr);
Console.Write($"Чисел больше 0: {result}"); */


/* Без запоминания(без массива) */

Console.Write("Введите число M: ");
int numberM = Math.Abs(int.Parse(Console.ReadLine()!));
int count = 0;
Console.WriteLine("Ведите M чисел: ");
for ( int i = 1; i <= numberM; i++) {
    int enterNumber = int.Parse(Console.ReadLine()!);
    if (enterNumber > 0) {
        count++;
    }
}
Console.WriteLine($"Чисел больше 0: {count}");