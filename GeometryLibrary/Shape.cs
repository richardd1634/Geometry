namespace Geometry;

public class Shape
{
  public Shape(double shapeHeight, double shapeWidth)
  {
    Height = shapeHeight;
    Width = shapeWidth;
    Area = shapeHeight * shapeWidth;
  }

  public double Height { get; set; }
  public double Width { get; set; }
  public double Area { get; }
}
