namespace homeWork_32_1;

public struct Cone : ICalculatable
{
    public string Name { get; set; }
    public double Radius { get; set; }
    public double Height { get; set; }

    public Cone(string name, double radius, double height)
    {
        Name = name;
        Radius = radius;
        Height = height;
    }

    public double CalculateVolume()
    {
        return (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
    }

    public double CalculateSquare()
    {
        double slantHeight = Math.Sqrt(Radius * Radius + Height * Height);
        return Math.PI * Radius * (Radius + slantHeight);
    }
}