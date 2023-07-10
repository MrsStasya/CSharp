// Задача 7. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
if(number>=100 && number <=999) Console.Write($"Последняя цифра из введенного числа равна {number % 10}");
else Console.Write ("Не верно");
