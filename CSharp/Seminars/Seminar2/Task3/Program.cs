// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

 Console.WriteLine("Введите первое число!");
 int first = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите второе число!");
 int second = int.Parse(Console.ReadLine());

int ostatok = first % second;

if(first % second == 0);
{
     Console.WriteLine($"Вы ввели числа {first} и {second}. Числа кратные");     
}

else 
{
 Console.WriteLine($"Вы ввели числа {first} и {second}. Числа не кратные, остаток {ostatok}");
  
}