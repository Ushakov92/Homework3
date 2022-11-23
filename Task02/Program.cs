// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите точку A1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку A2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку A3: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку B3: ");
int b3 = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int a2, int a3, int b1, int b2, int b3)
{
   double c1 = (b1 - a1) * (b1 - a1);
   double c2 = (b2 - a2) * (b2 - a2);
   double c3 = (a3 - b3) * (a3 - b3);
   double result = Math.Sqrt(c1 + c2 + c3);
   return result;
}
 
double res = Distance(a1, a2, a3, b1, b2, b3);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
