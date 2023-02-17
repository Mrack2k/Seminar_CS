// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int EvenNumbers (int[] number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
        {
            if (number[i] % 2 == 0) 
            result++;     
        }
    return result;
}



Console.Clear();
int a = InputNumber("Введите размер массива, чтобы заполнить его случайными положительными трёхзначными числами: "); 
int[] b = FillArray(a,100,999);
System.Console.Write("Заполнили массив: ");
PrintArray(b);
System.Console.WriteLine("Количество чётных чисел в массиве: " + EvenNumbers(b));
