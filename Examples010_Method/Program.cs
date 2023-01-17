


//Напишите программу, 
//которая принимает на вход координаты двух точек 
// находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;

double distance = GetDistance(x1, x2, y1, y2);
Console.WriteLine(distance);

double GetDistance(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}