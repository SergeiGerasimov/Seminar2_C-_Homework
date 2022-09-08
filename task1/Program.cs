// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

int SecondDigit(int num)
{
    while (number >= 100) number = number - 100;
    int firstDigit = number / 10;
    return firstDigit;
}

int result = SecondDigit(number);
Console.WriteLine($"Второе число - {result}");

