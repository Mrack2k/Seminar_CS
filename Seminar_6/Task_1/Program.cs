// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int InputNumber(string str)
{
    int num;
    string? text;
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

void PrintArray (int[] a)
{
    System.Console.WriteLine("[" + string.Join(", ", a) + "]");
}

int FindNumb (int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > 0) count++;   
        }
    return count;
}

Console.Clear();
int a = InputNumber("Сколько чисел будем вводить? -> "); 
int[] inputNum = new int[a];
for (int i = 0; i < a; i++)
    {
        inputNum[i] = InputNumber("Введите число -> ");
    }
Console.Clear();
Console.WriteLine("Вы ввели следующие числа: ");
PrintArray(inputNum);
System.Console.WriteLine("Количество чисел больше 0: " + FindNumb(inputNum));


