// Задача 21
// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber( string massageToUser)
{
    Console.WriteLine(massageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("Введите координату А по Х:");
double ya = ReadNumber("Введите координату А по Y:");
double za = ReadNumber("Введите координату А по Z:");
double xb = ReadNumber("Введите координату B по Х:");
double yb = ReadNumber("Введите координату B по Y:");
double zb = ReadNumber("Введите координату B по Z:");

double res = Math.Sqrt(Math.Pow(xb-xa, 2) + 
Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2) );

Console.WriteLine($"{res:f2}");