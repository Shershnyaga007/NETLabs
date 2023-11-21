using System.Drawing;

namespace Lab6;

abstract class Lab6
{
    public static void Main()
    {
        Point<double> pointC = new Point<double>(1.0, 2.0);
        Point<double> pointD = new Point<double>(5.0, 6.0);

        Point<double> distance = Point<double>.CalculateDistance(pointD, pointC);

        Point<double> pointA = Point<double>.Minus(pointC, distance);
        Point<double> pointB = Point<double>.Plus(pointD, distance);
        
        Console.WriteLine($"Coords of A: {pointA}");
        Console.WriteLine($"Coords of B: {pointB}");
    }
}

public class Point<T>
{
    public T X { get; set; }
    public T Y { get; set; }

    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public static Point<T> CalculateDistance(Point<T> p1, Point<T> p2)
    {
        dynamic sizeX = (dynamic)p2.X! - (dynamic) p1.X!;
        dynamic sizeY = (dynamic)p2.Y! - (dynamic) p1.Y!;
        return new Point<T>(sizeX, sizeY);
    }
    
    public static Point<T> Minus(Point<T> p1, Point<T> p2)
    {
        dynamic sizeX = (dynamic)p2.X! - (dynamic) p1.X!;
        dynamic sizeY = (dynamic)p2.Y! - (dynamic) p1.Y!;
        return new Point<T>(sizeX, sizeY);
    }
    
    public static Point<T> Plus(Point<T> p1, Point<T> p2)
    {
        dynamic sizeX = (dynamic)p2.X! + (dynamic) p1.X!;
        dynamic sizeY = (dynamic)p2.Y! + (dynamic) p1.Y!;
        return new Point<T>(sizeX, sizeY);
    }
}