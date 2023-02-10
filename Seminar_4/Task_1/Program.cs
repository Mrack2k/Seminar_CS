// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int MyPow(int a, int b) // возведение числа а в степень б вынесено в функцию...
{
    int result = a;
    for (int i = 2; i<=b; i++)
    {
        result = result * a;
    }
    return result;
}


int InputNumber(string str) // скопировал из семинара проверку на корректность ввода числа. Уже пробовал TryParse в предыдущем семинаре.. 
{
    int num;
    string text;
    while(true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out num))
        {
            break;
        }
        System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
    }
    return num;
}
Console.Clear();
int a = InputNumber("Введите число А: ");
int b = InputNumber("Введите число B: ");
System.Console.WriteLine("Результатом возведения числа А в степень B является число " + MyPow(a,b));

