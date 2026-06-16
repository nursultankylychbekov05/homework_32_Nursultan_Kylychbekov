namespace homeWork_32_1;

public struct Parallelepiped : ICalculatable
{
    public string Name { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Parallelepiped(string name, double length, double width, double height)
    {
        Name = name;
        Length = length;
        Width = width;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }

    public double CalculateSquare()
    {
        return 2.0 * (Length * Width + Length * Height + Width * Height);
    }
}