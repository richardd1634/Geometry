namespace Geometry;

public class Circle : Shape
{
  public Circle(double radius) : base() // Circle
  {
    Height = radius * 2;
    Width = radius * 2;
    Area = Math.PI * Math.Pow(radius, 2);
  }
}