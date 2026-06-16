namespace homeWork_32_2;

public struct Sphere : ICalculatable
{
    public string Name { get; set; }
    public double? Radius { get; set; }

    public Sphere(string name, double? radius)
    {
        Name = name;
        Radius = radius;
    }

    public double? CalculateVolume()
    {
        if (Radius == null) return null;
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius.Value, 3);
    }

    public double? CalculateSquare()
    {
        if (Radius == null) return null;
        return 4.0 * Math.PI * Math.Pow(Radius.Value, 2);
    }
}