/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int[] InputPoint(string PointName)
{
    Console.WriteLine();
    Console.WriteLine($"Введите координаты точки {PointName}.");
    int[] P = new int[3];
    string[] coord = new string[] { "x", "y", "z" };
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите {PointName}.{coord[i]}:");
        P[i] = Convert.ToInt32(Console.ReadLine());
    }
    return P;
}

double LengthP(int[] p1, int[] p2)
{
    double result = Math.Sqrt((p1[0] - p2[0]) * (p1[0] - p2[0])
                                + (p1[1] - p2[1]) * (p1[1] - p2[1])
                                + (p1[2] - p2[2]) * (p1[2] - p2[2]));
    return Math.Round(result, 2, MidpointRounding.ToZero);
}

int[] Point1 = new int[3];
int[] Point2 = new int[3];

Point1 = InputPoint("Point1");
Point2 = InputPoint("Point2");

double L = LengthP(Point1, Point2);
Console.WriteLine($"Расстояние между точками =  {L}.");

