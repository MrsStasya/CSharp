// Написать программу, которая на входе принимает 2 числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 ->да
// a = 2,  b = 10 ->нет
// а = 9,  b = -3 ->да
// a=-3.   b = 9  ->нет
Console.WriteLine("Введите число 1 ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int number2 = int.Parse(Console.ReadLine());

int sqr1 = number1*number1;
int sqr2 = number2*number2;

if(number1 == sqr2) Console.WriteLine($"Первое число {number1} является квадратом ({sqr2}) второго числа {number2}");
else Console.WriteLine($"Первое число {number1} не является квадратом ({sqr2}) второго числа {number2}");

if(number2 == sqr1) Console.WriteLine($"Второе число {number2} является квадратом ({sqr1}) первого числа {number1}");
else Console.WriteLine($"Второе число {number2} не является квадратом ({sqr1}) первого числа {number2}");