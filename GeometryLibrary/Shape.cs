namespace Geometry;

public class Shape
{
  public Shape(double height, double width)
  {
    Height = height;
    Width = width;
    Area = height * width;
  }

  public double Height { get; set; }
  public double Width { get; set; }
  public double Area { get; }
}
