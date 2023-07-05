// Нужно написать программу, которая бы находила "любимого пользователя" и здоровалась с ним по-особенному
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "настя")
{
    Console.WriteLine("Привет, солнышко!");
}
else
{
    Console.WriteLine("Привет, ");
}