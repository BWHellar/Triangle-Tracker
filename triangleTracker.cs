using System;

class Triangle  {

  public int One;
  public int Two;
  public int Three;
}

public class triangleTracker
{
  public static void Main()
  {
    Triangle triangle = new Triangle ();
    triangle.One = 0;
    triangle.Two = 0;
    triangle.Three = 0;

    Console.WriteLine("Length of side 1");
    triangle.One += int.Parse(Console.ReadLine());

    Console.WriteLine("Length of side 2");
    triangle.Two += int.Parse(Console.ReadLine());

    Console.WriteLine("Length of side 3");
    triangle.Three += int.Parse(Console.ReadLine());

    Console.WriteLine(triangle.One+","+triangle.Two+","+triangle.Three);

    if (triangle.One == triangle.Two && triangle.Two == triangle.Three)
    {
      Console.WriteLine("Equilateral Triangle");
    }
    else if (triangle.One == triangle.Two && triangle.Three <(triangle.One+triangle.Two)||
    triangle.One == triangle.Three && triangle.Two <(triangle.One+triangle.Three)||
    triangle.Three == triangle.Two && triangle.One<(triangle.Three+triangle.Two))
    {
      Console.WriteLine("Isosceles Triangle");
    }
    else if (triangle.One != triangle.Two && triangle.Two != triangle.Three && triangle.One != triangle.Three &&
       triangle.One < (triangle.Two + triangle.Three) &&
       triangle.Two < (triangle.One + triangle.Three) &&
       triangle.Three < (triangle.One + triangle.Two))
    {
      Console.WriteLine("Scalene Triangle");
    }
    else
    {
        Console.WriteLine("That's not a triangle");
    }

  }
}
