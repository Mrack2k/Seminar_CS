// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите трехмерные координаты точки A через пробел (X Y Z): ");
string a = Console.ReadLine();
string[] CoordA = a.Split(' '); // погуглил тк захотелось вводить координаты в одной строке
Console.Write("Введите трехмерные координаты точки B через пробел (X Y Z): ");
string b = Console.ReadLine();
string[] CoordB = b.Split(' ');
double s = Math.Sqrt( // Вычисляем расстояние между точками
                    Math.Pow(Convert.ToInt32(CoordB[0]) - Convert.ToInt32(CoordA[0]), 2) +
                    Math.Pow(Convert.ToInt32(CoordB[1]) - Convert.ToInt32(CoordA[1]), 2) +
                    Math.Pow(Convert.ToInt32(CoordB[2]) - Convert.ToInt32(CoordA[2]), 2)
                    );
System.Console.WriteLine("Расстояние между этими двумя точками в 3D простаранстве: " + s);