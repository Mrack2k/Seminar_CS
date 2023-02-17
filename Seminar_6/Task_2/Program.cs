// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решаем систему. Находим  x, а потом и y.
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x(k1-k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

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

void CrossPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    System.Console.Write("Точка пересечения двух прямых находится в координатах: ");
    System.Console.Write("X: " + x);
    System.Console.WriteLine(", Y: " + y);
}

Console.Clear();
double b1 = InputNumber("Введите b1 -> ");
double k1 = InputNumber("Введите k1 -> ");
double b2 = InputNumber("Введите b2 -> ");
double k2 = InputNumber("Введите k2 -> ");
CrossPoint(b1,k1,b2,k2);





