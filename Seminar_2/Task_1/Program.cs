﻿// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите трехзначное число: ");
string text = Console.ReadLine();
if (text.Length == 3) 
{
    int a = Convert.ToInt32(text);
    Console.WriteLine("Вторая цифра вычесленная математическим способом: " + a/10%10);
    Console.WriteLine("Вторая цифра вычесленная через массив: " + text[1]);
}
else 
{
    Console.WriteLine("Число не трехзначное!!!");
}
