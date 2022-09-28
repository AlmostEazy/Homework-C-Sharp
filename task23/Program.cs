/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1) {
    Console.WriteLine("Введите число больше 0");
}

for ( int count = 1; count <= n; count++) {
    Console.Write(Math.Pow(count, 3)); 

if (count != n) {
    Console.Write(", ");
} 
      
}



/* С записью в массив */

/* Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
List<double> arr = new List<double> ();             // double [] arr = new double [n];    

if (n < 1) {
    Console.WriteLine("Введите число больше 0");
}

for ( int count = 1; count <= n; count++) {         // for ( int count = 1, i = 0; count <= n; count++, i++) {
    double result = Math.Pow(count, 3);             // double result = Math.Pow(count, 3);
    arr.Add(result);                                // arr [i] = result;
}                                                   
Console.WriteLine(String.Join(", ", arr)); */
 
