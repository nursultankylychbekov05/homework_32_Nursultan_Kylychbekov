namespace homeWork_32_1;

public struct Sphere : ICalculatable
{
    public string Name { get; set; }
    public double Radius { get; set; }

    public Sphere(string name, double radius)
    {
        Name = name;
        Radius = radius;
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }

    public double CalculateSquare()
    {
        return 4.0 * Math.PI * Math.Pow(Radius, 2);
    }
}