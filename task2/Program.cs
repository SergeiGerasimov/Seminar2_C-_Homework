// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(100, 23000);
Console.WriteLine($"Случайное трехзначное число -> {number}");


while (number >= 1000) number = number / 10;
if (number >= 100)
{
    number = number % 10;
    Console.WriteLine($"Третье число - {number}");
}
else
{
    Console.WriteLine($"Третьего числа нет ");
}
