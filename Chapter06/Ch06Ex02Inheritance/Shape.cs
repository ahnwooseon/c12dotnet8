public class Shape
{
    public virtual double Area { get; }
}

public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public override double Area
    {
        get => Height * Width;
    }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
}

public class Square : Shape
{
    public double Length { get; set; }
    public override double Area
    {
        get => Length * Length;
    }

    public Square(double length)
    {
        Length = length;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area
    {
        get => Math.PI * Radius * Radius;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
}
