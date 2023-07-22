namespace Geometry;

public class Shape
{
  public Shape(double height, double width) // Rectangle
  {
    Height = height;
    Width = width;
    Area = height * width;
  }

  public Shape(double size) // Square
  {
    Height = size;
    Width = size;
    Area = Height * Width;
  }

  public Shape() // Circle
  {

  }

  public double Height { get; set; }
  public double Width { get; set; }
  public double Area { get; set; }
}
