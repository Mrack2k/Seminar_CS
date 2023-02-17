// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



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

int[] FillArray (int a, int lowrange, int highrange)
{
    int[] my_array = new int[a];
    Random rnd = new Random();
    for (int i = 0; i<a; i++)
        {
            my_array[i] = rnd.Next(lowrange, highrange +1);
        }
    return my_array;
}

void PrintArray (int[] a)
{
    System.Console.WriteLine("[" + string.Join(", ", a) + "]");
}

int SummNumbers (int[] number)
{
    int result = 0;
    for (int i = 1; i < number.Length; i = i + 2)
        {
            System.Console.WriteLine("Нечетная позиция " + i + " -> " + number[i]);
            result = result + number[i];     
        }
    return result;
}


Console.Clear();
int a = InputNumber("Введите размер массива: ");
int[] b = FillArray(a,-100,100);
System.Console.Write("Заполнили массив случайными числами от -100 до 100: ");
PrintArray(b);
System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SummNumbers(b));