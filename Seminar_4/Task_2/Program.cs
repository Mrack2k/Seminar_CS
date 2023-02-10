// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string InputNumber(string str) // проверяем чтобы было число, но возвращаем строку
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
    return text;
}

int SumNum(string a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(a[i]));
    }
    return sum;
}

Console.Clear();
string num = InputNumber("Введите целое число: ");
System.Console.WriteLine("Сумма цифр введенного числа равна " + SumNum(num));

