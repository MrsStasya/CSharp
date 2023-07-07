// Написать программу, которая будет выводить название дня недели по заданному номеру

Console.WriteLine("Напишите число от 1 до 7");
int day = int.Parse(Console.ReadLine());
if(day>8 || day<1) Console.WriteLine("Неверное число");

if(day == 1)
{
     Console.WriteLine("День недели понедельник"); //стандартный вариант
}
if(day == 2) Console.WriteLine("День недели вторник"); //упрощенный вариант(не всегда всем прокатывает. Иногда требуют классический вариант, лучше уточнять)
if(day == 3) Console.WriteLine("День недели среда");
if(day == 4) Console.WriteLine("День недели четверг");
if(day == 5) Console.WriteLine("День недели пятница");
if(day == 6) Console.WriteLine("День недели суббота");
if(day == 7) Console.WriteLine("День недели воскресенье");



