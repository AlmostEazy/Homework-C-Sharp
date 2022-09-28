/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = (int)Math.Abs(int.Parse(Console.ReadLine()!));
int firstDigit;
int secondDigit;
int fourthDigit;
int fifthDigit;

firstDigit = n / 10000;
secondDigit = (n / 1000) % 10;
fourthDigit = (n / 10) % 10;
fifthDigit = n % 10;

if ((n < 10000) || (n > 99999)) {
    Console.WriteLine("Вы ввели не пятизначное число! Повторите попытку!");
} else if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit)) {
    Console.WriteLine("Это палиндром!");
} else {
    Console.WriteLine("Это не палиндром!");
}
