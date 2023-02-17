// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76



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

double [] FillArray (int a, int lowrange, int highrange)
{
    double[] my_array = new double[a];
    Random rnd = new Random();
    for (int i = 0; i<a; i++)
        {
            my_array[i] = Math.Round(rnd.Next(lowrange,highrange) * rnd.NextDouble(), 3);
        }
    return my_array;
}

void PrintArray (double[] a)
{
    System.Console.WriteLine("[" + string.Join(", ", a) + "]");
}

double FindMax (double[] number)
{
    double max = number[0];
    for (int i = 1; i < number.Length; i++)
        {
            if (number[i] > max) max = number[i];   
        }
    return max;
}

double FindMin (double[] number)
{
    double min = number[0];
    for (int i = 1; i < number.Length; i++)
        {
            if (number[i] < min) min = number[i];   
        }
    return min;
}


Console.Clear();
int a = InputNumber("Введите размер массива: ");
double[] b = FillArray(a, 1, 100);
System.Console.WriteLine("Заполнили массив случайными вещественными числами от 1 до 100: ");
PrintArray(b);
double max = FindMax(b);
double min = FindMin(b);
System.Console.WriteLine("Разница между максимальным " + max + " и минимальным " + min + " элементами: " + (max-min));
