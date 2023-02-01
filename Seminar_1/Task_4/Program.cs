// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();   
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Все чётные числа от 1 до " + a +": ");
for (int i = 1; i <= a; i++)
{
if (i % 2 == 0) 
{
    Console.Write(" " + i);
}
} 
System.Console.WriteLine();
