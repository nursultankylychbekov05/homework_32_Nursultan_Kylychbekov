namespace homeWork_32_1;

public struct Cylinder : ICalculatable
{
    public string Name { get; set; }
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cylinder(string name, double radius, double height)
    {
        Name = name;
        Radius = radius;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(Radius, 2) * Height;
    }

    public double CalculateSquare()
    {
        return 2.0 * Math.PI * Radius * (Radius + Height);
    }
}