// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// заполнять будем элементами от 0 до 100

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

int[] FillArray (int a)
{
    int[] my_array = new int[a];
    Random rnd = new Random();
    for (int i = 0; i<a; i++)
        {
            my_array[i] = rnd.Next(0, 101);
        }
    return my_array;
}

Console.Clear();
int a = InputNumber("Введите размер массива: "); 
System.Console.WriteLine("[" + string.Join(", ", FillArray(a)) + "]");
