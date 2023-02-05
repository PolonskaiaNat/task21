// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите xA");
int xA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите yA");
int yA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите zA");
int zA= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите xB");
int xB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите yB");
int yB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите zB");
int zB= Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt(Math.Pow ((xB-xA),2) + Math.Pow ((yB-yA),2 ) + Math.Pow((zB-zA),2));

Console.WriteLine(Math.Round(L,2));



