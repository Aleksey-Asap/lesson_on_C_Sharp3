// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да
// Console.WriteLine("Введите пятизначное число:");
// int n = int.Parse(Console.ReadLine());
// int duplication = n;
// int r = 0;
// int a = 0;
// while (n > 0)
// {
//     a = n % 10;
//     r = r*10 + a;
//     n = n / 10;
// }
// if (duplication == r)
// {
//      Console.WriteLine("Это палиндром!");
// }
// else Console.WriteLine("Это не палиндром!");




// Задача 21: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X1");
// int X1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ввведите координату Y1");
// int Y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату Z1");
// int Z1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату Z2");
// int X2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Ввведите координату Y2");
// int Y2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату Z2");
// int Z2 = int.Parse(Console.ReadLine());
// double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
// Console.WriteLine(Math.Round(result, 2));

// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите целое положительно число");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
// while (i <= N)
// {
//     Console.Write(Math.Pow(i, 3) + " ");
//     i++;
// }