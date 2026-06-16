namespace homeWork_32_2;

public struct Cylinder : ICalculatable
{
    public string Name { get; set; }
    public double? Radius { get; set; }
    public double? Height { get; set; }

    public Cylinder(string name, double? radius, double? height)
    {
        Name = name;
        Radius = radius;
        Height = height;
    }

    public double? CalculateVolume()
    {
        if (Radius == null || Height == null) return null;
        return Math.PI * Math.Pow(Radius.Value, 2) * Height.Value;
    }

    public double? CalculateSquare()
    {
        if (Radius == null || Height == null) return null;
        return 2.0 * Math.PI * Radius.Value * (Radius.Value + Height.Value);
    }
}