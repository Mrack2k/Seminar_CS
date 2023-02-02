﻿//  Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
if (a > 99) 
{
    while (a > 999) 
    {
        a = a / 10;
    }
    Console.WriteLine("Третья цифра заданного числа математическим способом: " + a%10);
}
else 
{
    Console.WriteLine("Третьей цифры нет!!!");
}

if (text.Length >= 3)
{
    Console.WriteLine("Третья цифра заданного числа через строку: " + text[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет!!!");  
}