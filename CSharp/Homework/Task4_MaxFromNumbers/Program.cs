// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Ввведите первое число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ввведите второе число ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Ввведите третье число ");
int c = int.Parse(Console.ReadLine());

int max =0;
if(a>b)
{
    max = a;
}
else
{
max = b;
}
if(a>c)
{
    max = a;
}
else 
{
    max = c; 
}
if(b>c)
{
    max = b;
}
else max = c;
Console.WriteLine($"Максимальное число {max}");