// Задача 5. Напишите программу, которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до NConsole.WriteLine("Hello, World!");
// Вариант более длиный:
// Console.Write("Введите число ");
// int number = int.Parse(Console.ReadLine());
// int minusnumber = 0 - number;

// if(number<minusnumber)
// {
//     for(int i=number; i<= minusnumber; i++)
//     {
//         Console.Write($"{i} ");
//     }
// }
//     else
//     {
//         for(int i=minusnumber; i<=number; i++)
//         {
//                     Console.Write($"{i} ");
//         }
//     }

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int minusnumber = 0 - number; //можно написать number * (-1) или просто -number
for(int i = minusnumber; i<number; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine(number);
