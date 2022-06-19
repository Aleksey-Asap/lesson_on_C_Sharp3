// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве. 
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координату X1");
// int X1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ввведите координату Y1");
// int Y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату X2");
// int X2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ввведите координату Y2");
// int Y2 = int.Parse(Console.ReadLine());
// double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
// Console.WriteLine(Math.Round(result, 2));

// Задача 22: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
// 5 -> 1, 4, 9, 16, 25;
// 2 -> 1,4.
Console.WriteLine("Введите целое положительно число");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write(Math.Pow(i, 2) + " ");
    i++;
}